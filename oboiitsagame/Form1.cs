using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oboiitsagame
{
    public partial class Form1 : Form
    {
        private static BlockingCollection<Game1> _games = new BlockingCollection<Game1>();
        private static AutoResetEvent _stayAlive = new AutoResetEvent(false);

        public Form1()
        {
            InitializeComponent();
        }

        private void p1Button_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && textBox1.Text != string.Empty)
            {
                panel1.Visible = false;
                Task.Factory.StartNew(() =>
                {
                    using (var game = new Game1())
                    {
                        _games.Add(game);
                        game.Exiting += HandleGameExiting;
                        game.Run();
                    }
                });
            }
        }

        private void p2Button_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1 && textBox2.Text != string.Empty)
            {
                panel2.Visible = false;
                Task.Factory.StartNew(() =>
                {
                    using (var game = new Game1())
                    {
                        _games.Add(game);
                        game.Exiting += HandleGameExiting;
                        game.Run();
                    }
                });
            }
        }
        private static void HandleGameExiting(object sender, EventArgs e)
        {
            var game = sender as Game1;
            if (game != null)
            {
                Game1 gameToRemove;
                _games.TryTake(out gameToRemove);

                if (gameToRemove == null)
                {
                    return;
                }

                // If no more windows exist lets close everything down.
                if (_games.Count == 0)
                {
                    _stayAlive.Set();
                    Application.Exit();
                }
            }
        }
    }
}
