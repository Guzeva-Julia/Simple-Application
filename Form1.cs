/*Copyright(C) 2023 Huzieva Iyliia*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Huzeva_Lab15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Завдання 1
            buttonOK.Text = "Відповідь:";
            lblResult.Text = "";
            //Завдання 2
            butRes.Text = "Результат";
           lblres.Text = "";
            //Завдання 3
            butZnach.Text = "Результат";
            lblZnach.Text = "";
            //Завдання 4
            buttonOK1.Text = "OK";
            lblPassword.Text = "";
            //Завдання 5
            butZnat.Text = "Знайти";
            //Завдання 6
            butSuma.Text = "OK";
            lblSuma.Text = "";
            //Завдання 7
            butSymbolCount.Text = "OK";
            lblSymbolCount.Text = "";
        }
        /*Завдання 1
         * Обчислити значення виразу за формулою (усі змінні приймають дійсні значення):
        x-((x)^3/3)+((x)^5/5).*/
        private void buttonOK_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textX.Text);
            double result = (x - (Math.Pow(x, 3) / 3) + (Math.Pow(x, 5) / 5));
            lblResult.Text = result.ToString();
        }
        private void textX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра 
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою 
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (textX.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування 
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc> 
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter> 
                    // встановити курсор на кнопку OK 
                    buttonOK.Focus();
                return;
            }

            // інші  символи заборонені 
            e.Handled = true;
        }

        /*Завдання 2
         * Знайти суму членів геометричної прогресії, якщо відомі її перший 
        член, знаменник і число членів прогресії.*/

        private void butRes_Click(object sender, EventArgs e)
        {
            double b1 = Convert.ToDouble(textb1.Text); //перший член прогресії
            double q = Convert.ToDouble(textq.Text);    //знаменник
            double n = Convert.ToDouble(textn.Text);    //число членів прогресії
            double vidpovid = (b1 * Math.Pow(q, n - 1));   //формула геометричної прогресії
            lblres.Text = vidpovid.ToString();
        }

        private void textb1_KeyPress(object sender, KeyPressEventArgs e) 
        {

            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра 
                return;
            }
            

            if (e.KeyChar == '.')
            {
                // крапку замінемо комою 
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (textb1.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування 
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc> 
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter> 
                    // встановити курсор на кнопку ОК 
                    butRes.Focus();
                return;
            }

            // інші  символи заборонені 
            e.Handled = true;
        }

        private void textq_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра 
                return;
            }
            if (e.KeyChar != 0) { return; } //не дорівнює нулю
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою 
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (textb1.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування 
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc> 
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter> 
                    // встановити курсор на кнопку ОК 
                    butRes.Focus();
                return;

            }
            // інші  символи заборонені 
            e.Handled = true;
        }

        private void textn_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра 
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc> 
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter> 
                    // встановити курсор на кнопку ОК
                    butRes.Focus();
                return;
            }

            // інші  символи заборонені 
            e.Handled = true;
        }


        /*Завдання 3
        * Скласти  лінійну  програму,  яка  друкує  значення  true,  якщо 
        зазначене висловлення є дійсним, і false –  якщо ні: “Трикутник 
        зі сторонами а, b, с є рівностороннім”.*/
        private void butZnach_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(texta.Text);   //сторона а
            double b = Convert.ToDouble(textb.Text);    //сторона b
            double c = Convert.ToDouble(textc.Text);    //сторона с
                                                        // Перевірка, чи є трикутник рівностороннім
            bool znachennya = (a == b) && (b == c);
            butZnach.Text = znachennya.ToString();
            // Виведення результату
            if (znachennya)
            {
                lblZnach.Text = "Трикутник є рівностороннім.";
            }
            else
            {
                lblZnach.Text = "Трикутник не є рівностороннім.";
            }
        }
        private void texta_KeyPress(object sender, KeyPressEventArgs e)
            {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра 
             return;
             }
            if (e.KeyChar == '.')
            {
            // крапку замінемо комою 
            e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
              if (textX.Text.IndexOf(',') != -1)
                    {
                        // кома вже є в полі редагування 
                        e.Handled = true;
                    }
                    return;
                }
              if (Char.IsControl(e.KeyChar))
                 e.Handled = true;
            }
         private void textb_KeyPress(object sender, KeyPressEventArgs e)
            {
               if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                {
                    // цифра 
                    return;
                }
                if (e.KeyChar == '.')
                {
                    // крапку замінемо комою 
                    e.KeyChar = ',';
                }

                if (e.KeyChar == ',')
                {
                    if (textX.Text.IndexOf(',') != -1)
                    {
                        // кома вже є в полі редагування 
                        e.Handled = true;
                    }
                    return;
                }


                // інші  символи заборонені 
                e.Handled = true;
            }
            private void textc_KeyPress(object sender, KeyPressEventArgs e)
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                {
                    // цифра 
                    return;
                }
                if (e.KeyChar == '.')
                {
                    // крапку замінемо комою 
                    e.KeyChar = ',';
                }

                if (e.KeyChar == ',')
                {
                    if (textX.Text.IndexOf(',') != -1)
                    {
                        // кома вже є в полі редагування 
                        e.Handled = true;
                    }
                    return;
                }
                if (Char.IsControl(e.KeyChar))
                {
                    // <Enter>, <Backspace>, <Esc> 
                    if (e.KeyChar == (char)Keys.Enter)
                        // натиснута клавіша <Enter> 
                        // встановити курсор на кнопку OK 
                        butZnach.Focus();
                    return;
                }

                // інші  символи заборонені 
                e.Handled = true;
            }

       
        /*Завдання 4
        Написати програму, яка за паролем буде визначати рівень доступу 
        співробітника  до  секретної  інформації  в  базі  даних.  Доступ  до  бази  мають 
        тільки шість людей, розбитих на три групи за ступенем доступу. Вони мають 
        наступні  паролі:  9583,  1747  –  доступні  модулі  баз  А,  В,  С;  3331,  7922  – 
        доступні модулі баз В, С; 9455, 8997 – доступний модуль бази С. */
        private void buttonOK1_Click(object sender, EventArgs e)
        {
            // Оголошуємо список доступних паролів і модулів баз даних.
            Dictionary<string, string[]> passwords = new Dictionary<string, string[]>
    {
        { "9583", new string[] { "A", "B", "C" } },
        { "1747", new string[] { "A", "B", "C" } },
        { "3331", new string[] { "B", "C" } },
        { "7922", new string[] { "B", "C" } },
        { "9455", new string[] { "C" } },
        { "8997", new string[] { "C" } }
    };

            string password = textPassword.Text;

            // Перевіряємо, чи введений пароль є в списку доступних паролів.
            if (passwords.ContainsKey(password))
            {
                string[] modules = passwords[password];
                string accessLevel = "";

                // Визначаємо рівень доступу співробітника в залежності від його модулів доступу.
                if (modules.Contains("A") && modules.Contains("B") && modules.Contains("C"))
                {
                    accessLevel = "Високий рівень доступу";
                }
                else if (modules.Contains("B") && modules.Contains("C"))
                {
                    accessLevel = "Середній рівень доступу";
                }
                else if (modules.Contains("C"))
                {
                    accessLevel = "Низький рівень доступу";
                }

                lblPassword.Text = $"Рівень доступу: {accessLevel}";
            }
            else
            {
                lblPassword.Text = "Введено неправильний пароль. Спробуйте ще раз.";
            }
        }
        private void textPassword_KeyPress(object sender, KeyPressEventArgs e)
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                {
                    // цифра 
                    return;
                }
               
                if (Char.IsControl(e.KeyChar))
                {
                    // <Enter>, <Backspace>, <Esc> 
                    if (e.KeyChar == (char)Keys.Enter)
                        // натиснута клавіша <Enter> 
                        // встановити курсор на кнопку OK 
                        buttonOK1.Focus();
                    return;
                }

                // інші  символи заборонені 
                e.Handled = true;
            
        }
        /*Завдання 5.  
         * Натуральні  числа  а,  b,  с  називаються  числами  Піфагора,  якщо 
        виконується умова а^2  + b^2  = с^2 . Надрукувати всі числа Піфагора, менші N. */
        private void butZnat_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBoxN.Text); // максимальне значення числа Піфагора

            listBoxN.Items.Clear(); // очищаємо список перед виведенням результатів

            for (int a = 1; a <= n; a++)
            {
                for (int b = a; b <= n; b++) // починаємо перебір з a, щоб уникнути дублювання результатів
                {
                    int cSquared = a * a + b * b; // обчислюємо квадрат гіпотенузи

                    int c = (int)Math.Sqrt(cSquared); // обчислюємо гіпотенузу

                    if (c * c == cSquared && c <= n) // перевірка умови Піфагора та обмеження менше або рівно n
                    {
                        listBoxN.Items.Add($"{a}, {b}, {c}"); // додавання результату до списку
                    }
                }
            }
        }

         private void textBoxN_KeyPress(object sender, KeyPressEventArgs e)
            {
               if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
               {
                   // цифра 
                    return;
               }

                if (Char.IsControl(e.KeyChar))
                {
                    // <Enter>, <Backspace>, <Esc> 
                    if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter> 
                    // встановити курсор на кнопку Знайти 
                    butZnat.Focus();
                    return;
                }

                // інші  символи заборонені 
                e.Handled = true;        

        }
        /*Завдання 6.  
         * Дано послідовність n різних цілих чисел. Знайти суму її членів, 
        розташованих між максимальним і мінімальним значеннями (у суму включити 
        й обидва ці числа). */
        private void butSuma_Click(object sender, EventArgs e)
        {
            // Зчитування послідовності чисел з текстового поля та розбиття на масив чисел.
            string[] numsString = textNumbers.Text.Split();
            int[] nums = Array.ConvertAll(numsString, int.Parse);

            // Знаходження максимального та мінімального значень в масиві
            int max = nums.Max();
            int min = nums.Min();

            // Знаходження індексу максимального та мінімального значень в масиві.
            int maxIndex = Array.IndexOf(nums, max);
            int minIndex = Array.IndexOf(nums, min);

            // Обчислення суми елементів масиву між мінімальним та максимальним значеннями.
            int sum = 0;
            int startIndex = Math.Min(maxIndex, minIndex);
            int endIndex = Math.Max(maxIndex, minIndex);
            for (int i = startIndex; i <= endIndex; i++)
            {
                sum += nums[i];
            }

            // Виведення результату на екран.
            lblSuma.Text = $"Сума елементів між {min} та {max} дорівнює {sum}.";
        }

        private void textNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра 
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc> 
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter> 
                    // встановити курсор на кнопку Знайти 
                    butSuma.Focus();
                return;
            }
            e.Handled = true;
        }
        /*Завдання 7. 
         * Дано рядок символів, серед яких є двокрапка (:). Визначити,
        скільки символів їй передує.*/
        private void butSymbolCount_Click(object sender, EventArgs e)
        {
            string inputString = textInput.Text;

            int colonIndex = inputString.IndexOf(':');
            //На випадок, якщо двокрапки не будет, вивести повідомлення.
            if (colonIndex == -1)
            {
                lblSymbolCount.Text = $"Рядок не містить символу ':'" ;
                return;
            }
            //Захист від дурня
            string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!№;%:?*()_+-= "; // дозволені символи
            inputString = new string(inputString.Where(c => allowedChars.Contains(c)).ToArray()); // відфільтровуємо лише дозволені символи
            int symbolCount = colonIndex;

            lblSymbolCount.Text = $"Символів, що передують символу ':': {symbolCount}";
           
        }
    }
}
