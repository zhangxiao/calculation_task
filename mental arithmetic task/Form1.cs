using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;




namespace mental_arithmetic_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer_total.Interval = totaltime_org * 1000;       //定义为240，240s计算时间
            timer_1second.Interval = 1000;                          //设置timer_1second控件的Tick事件触发的时间间隔
            Minuend = 4000;
            score = 0;
            timer_show_result.Interval = 700;                        //用于答题后清除图片和关闭正确错误声音
            rightplayer.SoundLocation = "right_1.wav";          //正误时的声音文件
            wrongplayer.SoundLocation = "wrong.wav";
            restbeginplayer.SoundLocation = "rest.wav";
            gamebeginplayer.SoundLocation = "right_1.wav";

            //button10.Enabled = false;                                   //使能enter键
            timer_rest.Interval = resttime_second * 1000;       //剩余时间300s

            timer_remind.Interval = 8000;                               //做题8s时间限制

            timer_10min_rest .Interval = 600*1000;                   //休息10min，600s*1000

            axWindowsMediaPlayer1.SendToBack();
            axWindowsMediaPlayer1.Visible = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        int resttime_second = 300;          //5min休息时间，休息时为5*60
        int Minuend;
        int subtrahend = 7;
        static int totaltime;
        static int totaltime_org = 300;      //5min做题时间，5 * 60修改为10
        string subresult_input="";
        int subreslut_input_int;
        private Image rightImage = Image.FromFile(@"right.png");    //正误，休息时的图片文件
        private Image wrongImage = Image.FromFile(@"wrong.png");
        private Image restImage = Image.FromFile(@"rest.jpg");
       // private Button button10 = new Button();

        System.Media.SoundPlayer rightplayer = new System.Media.SoundPlayer();        //创建对象
        System.Media.SoundPlayer wrongplayer = new System.Media.SoundPlayer();
        System.Media.SoundPlayer restbeginplayer = new System.Media.SoundPlayer();
        System.Media.SoundPlayer gamebeginplayer = new System.Media.SoundPlayer();

        private static int score;
        private static int right_number;
        private static int wrong_number;
        private static string scorefile = @"D:/score.txt";         //存储得分的文件夹
        string begingtime;
        string restbegingtime_str;

        Random ran = new Random();                            //用于产生随机数
        int start_index = 0;
        int end_index = 0;
        int count1 = 0;                                                     //点击那个relax按钮
        int count = 0;                                                       //点击那个任务难度

        /*开始按钮*/
        private void button26_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请观看视频10min放松");
            button26.Visible = false;
            axWindowsMediaPlayer1.URL = @"D:\2.mp4";
            
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = 20;         //从指定位置开始播放视频
            axWindowsMediaPlayer1.Ctlcontrols.play();       //直接调用播放器即可

            timer_10min_rest.Start();

            //totaltime = resttime_second;        //总时间300s
            //timer_1second.Start();                  //打开300s减1s定时器（实质是用于5分钟休息时的读秒）
            //timer_rest.Start();                         //当有300s后才会进到Tick事件中
            //timer_remind.Start();                    //在计算开始后启动
            restbegingtime_str = DateTime.Now.ToLocalTime().ToString(); // 记录视频开始播放的时间
            axWindowsMediaPlayer1.SendToBack();
        }       

     


        /*每1s触发一次此事件*/
        private void timer_1second_Tick(object sender, EventArgs e)
        {
            try
            { 
                progressBar1.Value = progressBar1.Value - 1;            //此处时间容易出现负数发生异常，使用try..catch..语句
            }
            catch (Exception ex) //必须按形式写好，否则提示变量未声明
            {

            }           
            label_time.Text = "Time Left: " + totaltime.ToString()+"s";
            totaltime--;
        }


        /*输入数字后显示*/
        private void button_Click(int n)
        {
            subresult_input = subresult_input + n.ToString();
            label_subresult.Text = subresult_input;         //注意清除的内容
        }

      

        /*删除del按钮，应该只删除一位*/
        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Focused)
            {
                if (textBox1.Text.Length > 0)
                {
                    string strTest = this.textBox1.Text.Substring(0, textBox1.Text.Length - 1);         //输入姓名出现错误删除最后一位
                    this.textBox1.Text = strTest;
                }                               
            }
            else
            {
                if (subresult_input.Length > 0)
                {
                    subresult_input = subresult_input.Remove(subresult_input.Length - 1, 1);            //删除最近输入的一位数
                }
                label_subresult.Text = subresult_input;     //将结果输入框中内容清空
            }            
        }

        /*enter键按下后判断输入结果是否正确*/
        private void Judge_resull()
        {
            if (subresult_input != "")
            {
                subreslut_input_int = int.Parse(subresult_input);           //将键盘输出结果转化为int类型
                subresult_input = "";                                                       //按下enter键，后面的结果都要清空，此句必须放在前面，不能放在此模块的最后面（暂时没找到原因）      

                if (subreslut_input_int == Minuend - subtrahend)        //subtrahend应设置为随机数
                {
                    //判断正确
                    pictureBox1.Image = rightImage;                             //显示正误图形的box
                    score = score + 5;                                                    //做对一题加5
                    right_number++;                                                     //用于将做对提数记录在txt中

                    Minuend = subreslut_input_int;                                //将新的结果显示在被减数标签中
                    label_Minuend.Text = Minuend.ToString();

                    rightplayer.LoadAsync();                                            //做题正确时声音
                    //rightplayer.Stop();
                    rightplayer.PlayLooping();
                }
                else
                {
                    //判断错误
                    pictureBox1.Image = wrongImage;
                    score = score - 3;                                                      //错一题减3分
                    wrong_number++;

                    wrongplayer.LoadAsync();
                    //wrongplayer.Stop();                   
                    wrongplayer.PlayLooping();
                }
                label_score.Text = "Score: " + score.ToString();              //一轮计算完显示累计分数
                label_subresult.Text = subresult_input;                          //输入结果subresult_input显示在 label_subresult标签中
                timer_show_result.Start();                                              //无论结果正确与否，启动0.7s定时器，清除图片和停止声音播放

                timer_remind.Stop();                                                    //无论做题正确与否，重新启动5s做题计时器
                timer_remind.Start();
            }

            subtrahend = ran.Next(start_index, end_index);                 //产生随机减数
            label7.Text = subtrahend.ToString();                                  //将产生的随机数显示在减数标签中
                                                                    
        }


        /*计算时间满300s，会触发此事件*/
        private void timer_total_Tick(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.fullScreen = false;
            label_subresult.Enabled = false;  //计算时间满240s不能通过键盘输入数字了
            //button10.Enabled = false;

            timer_1second.Stop();
            timer_total.Stop();

            wrongplayer.Stop();
            rightplayer.Stop();
            timer_show_result.Stop();                                           //每一轮计算结束，倒计时通知
            timer_remind.Stop();                                                   //每一轮计算结束后，都要把5s做题定时器关掉
            if (count1 == 0)
            { MessageBox.Show("计算时间已用完，请单击”relax1“按钮播放视频5min放松"); }
            if(count1 ==1)
            { MessageBox.Show("计算时间已用完，请单击”relax2“按钮播放视频5min放松"); }
            if (count1 == 2)
            { MessageBox.Show("计算时间已用完，测试结束"); }
            count1++;

            StreamWriter sw = new StreamWriter(scorefile, true);
            sw.WriteLine("restbegin:" + restbegingtime_str);        //记录休息的开始时间
            sw.WriteLine("gamebeging:" + begingtime);
            sw.WriteLine("name: " + textBox1.Text + " score: " + score + "  " + " Minued :" + Minuend.ToString() + "  " + "ringht:" + right_number.ToString() + "  " + "wrong:" + wrong_number.ToString());
            sw.WriteLine("\r\n");
            sw.Flush();
            sw.Close();
        }

        /*答题后的0.7s，取消正误图片的显示，停止正误播放声音*/
        /*声音问题在此处查找*/
        private void timer_show_result_Tick(object sender, EventArgs e)
        {
            timer_show_result.Stop();
            pictureBox1.Image = null;
            wrongplayer.Stop();
            rightplayer.Stop();
        }

        /*用于点easy medium hard按钮后直接开始计算，单独构造成一个函数*/
        private void calculation( )
        {
            timer_show_result.Start();            //点击难度按钮后就开始7s倒计时
            //timer_remind.Interval = 10000;
            gamebeginplayer.LoadAsync();
            gamebeginplayer.PlayLooping();

            timer_rest.Stop();                          //300s到，进入对应的Tick事件，将定时器关掉（这句应该可以去掉了）
            //pictureBox2.SendToBack();           //除了开始按钮外的所有部分，SendToBack函数作用

            totaltime = totaltime_org;            //240s
            score = 0;                                    //统计参数清零
            right_number = 0;
            wrong_number = 0;
            subresult_input = "";                   //输入结果清空
            Minuend = 4000;
            timer_total.Stop();
            timer_1second.Stop();

            //button10.Enabled = true;
            timer_1second.Start();               //再次调用读秒定时器，用于做题时240s的读秒
            timer_total.Start();
            label_Minuend.Text = Minuend.ToString();
            label_score.Text = "Score: " + score.ToString();
            label_subresult.Text = subresult_input;

            subtrahend = ran.Next(start_index, end_index);//产生初值
            label7.Text = subtrahend.ToString();

            begingtime=DateTime.Now.ToLocalTime().ToString();
            timer_remind.Start();                   //启动5s做题倒计时
        }

        /*10min休息时间完*/
        private void timer_10min_rest_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = 300;
            label_time.Text = "Time Left: " + "300s";

            axWindowsMediaPlayer1.fullScreen = false;
            axWindowsMediaPlayer1.Visible = false;          //播放器隐藏
            axWindowsMediaPlayer1.Ctlcontrols.pause();  //暂停需要加上前面的Ctlcontrols 

            timer_10min_rest.Stop();
            { MessageBox.Show("请输入姓名，单击“Easy”按钮，通过键盘输入计算结果"); }
           
        }

        /*300s后(视频播放完毕)会触发此事件*/
        private void timer_rest_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = 300;
            label_time.Text = "Time Left: " + "300s";

            axWindowsMediaPlayer1.fullScreen = false;
            axWindowsMediaPlayer1.Visible = false;          //播放器隐藏
            axWindowsMediaPlayer1.Ctlcontrols.pause();  //暂停需要加上前面的Ctlcontrols           
            timer_rest.Stop();
            timer_1second.Stop();                                   
            //if (count == 0)
            //{ MessageBox.Show("请输入姓名，单击“Easy”按钮，通过键盘输入计算结果"); }
            count++;
            if(count==1)
            { MessageBox.Show("单击“Medium”按钮，通过键盘输入计算结果"); }
            if (count == 2)
            { MessageBox.Show("单击“Hard”按钮，通过键盘输入计算结果"); }
            
        }

        /*5s时间到还没回答出计结果*/
        private void timer_remind_Tick(object sender, EventArgs e)
        {          
            //设置button按钮无法按下
            //button1.Enabled = false; button2.Enabled = false; button3.Enabled = false; button4.Enabled = false; button5.Enabled = false;
            //button6.Enabled = false; button7.Enabled = false; button8.Enabled = false; button9.Enabled = false; button10.Enabled = false;

            pictureBox1.Image = wrongImage;            
            subresult_input = "";           //注意清除内容，清除subresult_input，而不是清除label_subresult
                       
            score = score - 3;                                                      //错一题减3分
            wrong_number++;
      
            wrongplayer.LoadAsync();
            wrongplayer.PlaySync();             //用此句图片显示会有延迟
            //wrongplayer.Play();                   //用此句错误声音会很短
            //wrongplayer.PlayLooping();      //用此句错误声音会很短

            label_score.Text = "Score: " + score.ToString();         //一轮计算完显示累计分数
            label_subresult.Text = string.Empty;                          //输入结果subresult_input显示在 label_subresult标签中

            timer_show_result.Start();                                           //没输入任何结果，启动0.7s定时器，清除图片和停止声音播放

            subtrahend = ran.Next(start_index, end_index);                 ////显示错误后开始重新出题，产生随机减数
            label7.Text = subtrahend.ToString();                                  //将产生的随机数显示在减数标签中
            
            restbeginplayer.Stop();
            gamebeginplayer.Stop();

            //wrongplayer.PlaySync();

            timer_remind.Stop();
            timer_remind.Start();//重新开始5s倒计时
        }

        /*Easy按钮按下*/
        private void button13_Click(object sender, EventArgs e)
        {
            //groupBox4.Visible = false;
            //groupBox3.Enabled = true;  

            start_index = 1;
            end_index = 5;
            calculation();      //启动定时器开始计算时间的倒计时

            //启动单题倒计时

            this.label_subresult.Focus();
           


        }
        
        /*第一个relax1按钮*/
        private void button16_Click(object sender, EventArgs e)
        {
            restbegingtime_str = DateTime.Now.ToLocalTime().ToString();

            label7.Text = "";
            label_score.Text = "Score: " + "";

            axWindowsMediaPlayer1.fullScreen = true;
            axWindowsMediaPlayer1.Visible = true;
            axWindowsMediaPlayer1.Ctlcontrols.play();

            label_Minuend.Text = "";
            label_subresult.Text = "?";

            totaltime = resttime_second;        //总时间300s
            timer_1second.Start();                  //打开300s减1s定时器（实质是用于5分钟休息时的读秒）
            timer_rest.Start();                         //当有300s后才会进到Tick事件中
            //timer_remind.Start();                   //休息时

        }

        /*Medium按钮按下*/
        private void button14_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 300;
            label_subresult.Enabled = true;  
            start_index = 6;
            end_index = 9;
            calculation();

            this.label_subresult.Focus();
            
        }

        /*第二个relax2按钮*/
        private void button17_Click(object sender, EventArgs e)
        {
            restbegingtime_str = DateTime.Now.ToLocalTime().ToString();

            label7.Text = "";
            label_score.Text = "Score: " + "";

            label_Minuend.Text = "";
            label_subresult.Text = "?";

            axWindowsMediaPlayer1.fullScreen = true;
            axWindowsMediaPlayer1.Visible = true;
            axWindowsMediaPlayer1.Ctlcontrols.play();

            totaltime = resttime_second;        //总时间300s
            timer_1second.Start();                  //打开300s减1s定时器（实质是用于5分钟休息时的读秒）
            timer_rest.Start();                         //当有300s后才会进到Tick事件中

            //timer_remind.Start();                     //启动3s计时器
        }
       
        /*Hard按钮按下*/
        private void button15_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 300;
            label_subresult.Enabled = true;  
            start_index = 15;
            end_index = 19;
            calculation();

            //this.button10.Focus();
            //button10.PerformClick();
            // Judge_resull();
            this.label_subresult.Focus();
        }


        /*PC键盘映射，用keypress事件*/
        private void Form1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == '1')
            {
                button_Click(1); // 执行按钮1的操作
                e.Handled = true;
            }

            if (e.KeyChar == '2')
            {
                button_Click(2); // 执行按钮2的操作
                e.Handled = true;
            }

            if (e.KeyChar == '3')
            {
                button_Click(3); // 执行按钮3的操作
                e.Handled = true;
            }

            if (e.KeyChar == '4')
            {
                button_Click(4); // 执行按钮4的操作
                e.Handled = true;
            }

            if (e.KeyChar == '5')
            {
                button_Click(5); // 执行按钮5的操作
                e.Handled = true;
            }

            if (e.KeyChar == '6')
            {
                button_Click(6); // 执行按钮6的操作
                e.Handled = true;
            }

            if (e.KeyChar == '7')
            {
                button_Click(7); // 执行按钮7的操作
                e.Handled = true;
            }

            if (e.KeyChar == '8')
            {
                button_Click(8); // 执行按钮8的操作
                e.Handled = true;
            }

            if (e.KeyChar == '9')
            {
                button_Click(9); // 执行按钮9的操作
                e.Handled = true;
            }

            if (e.KeyChar == '0')
            {
                button_Click(0); // 执行按钮0的操作
                e.Handled = true;
            }

            if (e.KeyChar == '\b')  
            {
                button11_Click(null,null);  //按下backspace键删除输入内容
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                //this.button10.Focus();
                //button10.PerformClick();
                Judge_resull();
            }
        }



        #region



        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        #endregion
    }        
}
