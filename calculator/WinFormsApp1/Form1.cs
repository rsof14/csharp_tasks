using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace WinFormsApp1
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        float first_numb, second_numb;
        int count;
        bool positive = true;
        bool after_eq = false;
        bool after_operation = false;
        bool zero_error = false;
        string logging_path = @"D:\csharp\logging.txt";
        string[] operations = { "+", "-", "*", "/" };
        string loggs = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            using (FileStream fstream = new FileStream(logging_path, FileMode.Create))
            {
                byte[] buffer = Encoding.Default.GetBytes("Calculations");
                fstream.Write(buffer, 0, buffer.Length);
            }
        }

        private void write_loggs(string loggs)
        {
            using (FileStream fstream = new FileStream(logging_path, FileMode.Append))
            {
                byte[] buffer = Encoding.Default.GetBytes(Environment.NewLine + loggs);
                fstream.Write(buffer, 0, buffer.Length);
            }
        }

        private void clear_field()
        {
            output_box.Text = "0";
            process_box.Text = "";
        }
        private void handle_numb_button_click(int numb)
        {
            if (after_eq == true)
            {
                clear_field();
                after_eq = false;
            }
            if (after_operation == true)
            {
                output_box.Text = "0";
            }
            if (output_box.Text != "0" && numb == 0)
            {
                output_box.Text = output_box.Text + 0;
                return;
            }
            if (output_box.Text == "0")
            {
                output_box.Text = numb.ToString();
            }
            else
            {
                output_box.Text = output_box.Text + numb;
            }
            after_operation = false;
            zero_error = false;
        }

        private void make_operation(int operation_numb)
        {
            if (zero_error == false)
            {
                if (after_operation == true)
                {
                    count = operation_numb;
                    process_box.Text = process_box.Text.Substring(0, process_box.Text.Length - 1) + operations[operation_numb];
                    return;
                }
                if (process_box.Text != "")
                {
                    calculate();
                    if (zero_error)
                    {
                        return;
                    }
                }
                string output_value = output_box.Text;
                output_box.Text = output_box.Text.Replace("-", "");
                first_numb = float.Parse(output_box.Text);
                if (positive == false)
                {
                    first_numb *= -1;
                }
                output_box.Text = output_value;
                count = operation_numb;
                process_box.Text = output_value + " " + operations[operation_numb];
                after_operation = true;
                after_eq = false;
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            clear_field();
            positive = true;
            after_eq = false;
            after_operation = false;
            zero_error = false;
        }

        private void dot_button_Click(object sender, EventArgs e)
        {
            if (output_box.Text.Contains(",") == false)
            {
                output_box.Text = output_box.Text + ",";
            }
            after_operation = false;
        }

        private void posneg_button_Click(object sender, EventArgs e)
        {
            if (output_box.Text != "0" && zero_error == false)
            {
                if (output_box.Text.Substring(0, 1) == "-")
                {
                    positive = true;
                    output_box.Text = output_box.Text.Replace("-", "");
                    if (after_operation)
                    {
                        process_box.Text = process_box.Text.Replace("-", "");
                    }
                }
                else
                {
                    positive = false;
                    output_box.Text = "-" + output_box.Text;
                    if (after_operation)
                    {
                        process_box.Text = "-" + process_box.Text;
                    }
                }
            }
        }

        private void calculate()
        {
            switch (count)
            {
                case 0:
                    second_numb = first_numb + float.Parse(output_box.Text);
                    loggs = first_numb.ToString() + "+" + output_box.Text + "=" + second_numb;
                    output_box.Text = second_numb.ToString();
                    write_loggs(loggs);
                    break;
                case 1:
                    second_numb = first_numb - float.Parse(output_box.Text);
                    loggs = first_numb.ToString() + "-" + output_box.Text + "=" + second_numb;
                    output_box.Text = second_numb.ToString();
                    write_loggs(loggs);
                    break;
                case 2:
                    second_numb = first_numb * float.Parse(output_box.Text);
                    loggs = first_numb.ToString() + "*" + output_box.Text + "=" + second_numb;
                    output_box.Text = second_numb.ToString();
                    write_loggs(loggs);
                    break;
                case 3:
                    if (float.Parse(output_box.Text) == 0.0)
                    {
                        output_box.Text = "Некорректно";
                        zero_error = true;
                    }
                    else
                    {
                        second_numb = first_numb / float.Parse(output_box.Text);
                        loggs = first_numb.ToString() + "/" + output_box.Text + "=" + second_numb;
                        output_box.Text = second_numb.ToString();
                        write_loggs(loggs);

                    }

                    break;
                default:
                    break;
            }
        }

        private void eq_button_Click(object sender, EventArgs e)
        {
            if (process_box.Text != "" && zero_error == false)
            {
                calculate();
                process_box.Text = "";
                after_eq = true;
                after_operation = false;
            }
            else if (zero_error)
            {
                clear_field();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            handle_numb_button_click(0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            handle_numb_button_click(1);
        }


        private void two_button_Click(object sender, EventArgs e)
        {
            handle_numb_button_click(2);
        }

        private void three_button_Click(object sender, EventArgs e)
        {
            handle_numb_button_click(3);
        }

        private void four_button_Click(object sender, EventArgs e)
        {
            handle_numb_button_click(4);
        }

        private void five_button_Click(object sender, EventArgs e)
        {
            handle_numb_button_click(5);
        }

        private void six_button_Click(object sender, EventArgs e)
        {
            handle_numb_button_click(6);
        }

        private void seven_button_Click(object sender, EventArgs e)
        {
            handle_numb_button_click(7);

        }

        private void eight_button_Click(object sender, EventArgs e)
        {
            handle_numb_button_click(8);

        }

        private void nine_button_Click(object sender, EventArgs e)
        {
            handle_numb_button_click(9);

        }      

        

        private void plus_button_Click(object sender, EventArgs e)
        {
            make_operation(0);
        }

        private void minus_button_Click(object sender, EventArgs e)
        {
            make_operation(1);
        }

        private void mult_button_Click(object sender, EventArgs e)
        {
            make_operation(2);
        }

        private void div_button_Click(object sender, EventArgs e)
        {
            make_operation(3);
        }

        


    }
}