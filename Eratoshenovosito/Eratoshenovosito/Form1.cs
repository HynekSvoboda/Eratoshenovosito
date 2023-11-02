using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eratoshenovosito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                int n = int.Parse(textBox1.Text);
                List<int> prvocisla = new List<int>();
                if (n > 1)
                {
                    bool[] cisla = new bool[n + 1];
                    for (int i = 2; i <= n; i++)
                    {
                        cisla[i] = true;
                    }

                    for (int p = 2; p <= n; p++)
                    {
                        if (cisla[p])
                        {
                            prvocisla.Add(p);

                            for (int i = p * 2; i <= n; i += p)
                            {
                                cisla[i] = false;
                            }
                        }
                    }

                    foreach (int prvocislo in prvocisla)
                    {
                        listBox1.Items.Add(prvocislo);
                    }
                }
                else MessageBox.Show("Žádné prvočísla nenalezena","INFO");
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("V textBox1 je celé kladné číslo n. Do listBox1 vypište všechna prvočísla menší nebo\r\nrovna n. Vyřešte pomocí Eratoshenova síta.\r\n(Jeden z možných způsobů – vytvořte si pole bool o velikosti n. Indexy představují\r\nzkoumanou posloupnost čísel, index nula neberte v úvahu. Na začátku inicializujte všechny\r\nprvky pole na false, začněte od indexu 2, vyškrtávání násobků prvočísel realizujte zápisem\r\nhodnoty true na příslušném indexu.)", "INFO");
        }
    }
}
