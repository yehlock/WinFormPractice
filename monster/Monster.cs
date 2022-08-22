using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using static monster.Message;
using static monster.Monster;
using static System.Net.Mime.MediaTypeNames;
using Timer = System.Windows.Forms.Timer;

namespace monster
{
    internal class Monster
    {
        public delegate void UpdateMessageDelegate(string message);
        public event UpdateMessageDelegate OnUpdateMessageDelegate;
        private System.Timers.Timer timer;


        public ListBox form_listbox;
        public string monster_name { get; set; }
        public string monster_type { get; set; }
        public virtual string message { get; set; } = "No message";
        public int time { get; set; } = 9;
        public bool isAlive = true;
        private object lbxMessage;
        private int sendMessageTimes = 0;

        public int monster_id { get; set; }

        delegate void MyDelegate(String msg);
        public void StartWork()
        {
            timer = new System.Timers.Timer(time * 1000);
            timer.Elapsed += SendMessageOnTimed;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
        private void SendMessageOnTimed(object? sender, ElapsedEventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            string msg = $"{dateTime}       I'm {this.monster_name}. ({this.monster_type}, {monster_id})  {++sendMessageTimes}";
            if (OnUpdateMessageDelegate != null)
            {
                OnUpdateMessageDelegate(msg);
            }
        }
        public void Delete()
        {
            timer.Enabled = false;
            //Debug.WriteLine("delete");
            //GC.Collect();
        }

        public void Restart()
        {
            timer.Enabled = true;
            //Debug.WriteLine("restart");
        }
    }
}
