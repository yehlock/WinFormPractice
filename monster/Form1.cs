using System.Collections;
using System.Diagnostics;
using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Threading;
using static monster.Form1;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace monster
{
    public delegate void setMsg(string msg);

    public partial class Form1 : Form
    {
        List<Monster> monsterslist = new List<Monster>();
        int id = 0;
        internal static List<string> aliveMonster;
        internal static List<Object> aliveMonsterClass;
        public delegate void DsetMessage(string message);
        private string[] monsterStatue = { "Alive", "Resume", "Dead" };

        Monster m;

        public Form1()
        {
            InitializeComponent();
            aliveMonster = new List<string>();
            //setMsg set = new(Show);
            InitialListView();

        }

        private void InitialListView()
        {
            lvwArray.Items.Clear();
            lvwArray.View = View.Details;
            lvwArray.GridLines = true;
            lvwArray.LabelEdit = false;
            lvwArray.FullRowSelect = true;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string? name = txtName.Text;
            string type = cmbType.Text;
            string nameWarning = "請輸入名字";
            string typeWarning = "請選擇Type";
            if (name == "" || type == "" || name == nameWarning || type == typeWarning)
            {
                txtName.Text = nameWarning;
                cmbType.Text = typeWarning;
            }
            else
            {
                createMonster(name, type);
                this.Controls.Add(lvwArray);
            }
            this.update_message(name + " added");
        }
        public void update_message(String message)
        {

            if (this.lbxMessage.InvokeRequired)
            {
                DsetMessage d = new(update_message);
                try
                {
                    this.Invoke(d, message);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
                
            }
            else
            {
                string[] str = message.Split(" ");
                int.TryParse(str[str.Length - 1], out int count);
                
                if (count != 0)
                {
                    message = "";
                    for (int i = 0; i < str.Length - 1; i++)
                    {
                        message += str[i] + " ";
                    }
                    string s = str[str.Length - 3].ToString();
                    s = s.Replace(")", string.Empty);
                    int.TryParse(s, out int countId);
                    for(int i=0; i < lvwArray.Items.Count; i++)
                    {
                        if(lvwArray.Items[i].SubItems[0].Text == countId.ToString())
                        {
                            lvwArray.Items[i].SubItems[4].Text = count.ToString();
                            break;
                        }
                        
                    }
                    
                }
                

                lbxMessage.SelectedIndex = lbxMessage.Items.Count - 1;
                lbxMessage.SelectedIndex = -1;
                lbxMessage.Items.Add(message);
            }
        }

        private void createMonster(string name, string type)
        {

            string[] item = new string[5];
            id++;
            item[0] = id.ToString();
            item[1] = name;
            item[2] = type;
            item[3] = monsterStatue[0];
            item[4] = "0";
            ListViewItem setItem = new ListViewItem(item);
            lvwArray.Items.Add(setItem);


            if (type.ToLower() == "type 1")
            {
                string msg;
                Type1 type1 = new Type1(id, name);
                type1.form_listbox = this.lbxMessage;
                type1.OnUpdateMessageDelegate += update_message;
                m = type1;
                if (m != null)
                {
                    monsterslist.Add(m);
                    //Debug.WriteLine(monsterslist.Count());
                }
                type1.StartWork();
            }
            else
            {
                Type2 type2 = new Type2(id, name);
                m = type2;
                type2.form_listbox = this.lbxMessage;
                type2.OnUpdateMessageDelegate += update_message;
                m = type2;
                if (m != null)
                {
                    monsterslist.Add(m);
                    Debug.WriteLine(monsterslist.Count());
                }
                type2.StartWork();
            }
        }

        //public void Show(string msg)
        //{
        //    string[] str = msg.Split(" ");
        //    Debug.WriteLine(str[str.Length-1]);

        //    //lbxMessage.Items.Add(msg);
        //}  

        private void lvwArray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lvwArray.SelectedIndices[0];

            string messageBoxMsg = $"你想要復活怪獸嗎? (ID:{index})"+
                "\n復活怪獸點擊 Yes \n" +
                "殺死怪獸點擊 No"; 

            if (lvwArray.Items[index].SubItems[3].Text != monsterStatue[1])
            {
                messageBoxMsg = $"你想要殺死怪獸嗎? (ID:{index})"  +
                "\n殺死怪獸點擊 Yes \n" +
                "暫停怪獸點擊 No";

                DialogResult result = MessageBox.Show(messageBoxMsg, "Delete",  MessageBoxButtons.YesNoCancel);
                //PopUpDialogue popUpDialogue = new PopUpDialogue("Delete", messageBoxMsg, "Kill", "Pause", "Cencal");
                //DialogResult re = popUpDialogue.ShowDialog();
                //DialogResult result = CustomMessageBox.Show("Delete",messageBoxMsg,"1","2","3");
                Debug.WriteLine("result = "+ result);
                //string MyResult = popUpDialogue.ShowDialogue("Delete", messageBoxMsg, "Kill", "Pause", "Cencal");
                if (result == DialogResult.Yes)
                {
                    Monster monster = monsterslist.ElementAt(index);
                    monsterslist.RemoveAt(index);
                    monster.Delete();
                    lvwArray.Items.RemoveAt(index);
                }
                else if (result == DialogResult.No)
                {
                    Monster monster = monsterslist.ElementAt(index);
                    monster.Delete();
                    lvwArray.Items[index].SubItems[3].Text = monsterStatue[1];
                }
            }
            else
            {
                DialogResult result = MessageBox.Show(messageBoxMsg,"Delete", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    Monster monster = monsterslist.ElementAt(index);
                    monster.Restart();
                    lvwArray.Items[index].SubItems[3].Text = monsterStatue[0];
                }
                else if(result == DialogResult.No)
                {
                    Monster monster = monsterslist.ElementAt(index);
                    monsterslist.RemoveAt(index);
                    monster.Delete();
                    lvwArray.Items.RemoveAt(index);
                }
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < monsterslist.Count; i++)
            {
                Monster monster = monsterslist.ElementAt(i);
                monster.Delete();
            }
            lvwArray.Items.Clear();
            monsterslist.Clear();
            id = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnDeleteAll_Click(sender, e);
        }

        private void btnClearMessage_Click(object sender, EventArgs e)
        {
            lbxMessage.Items.Clear();
        }
    }
}