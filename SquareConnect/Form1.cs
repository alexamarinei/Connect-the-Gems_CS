using SquareConnect.SStack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareConnect
{
    public partial class Form1 : Form
    {
        SquareStack sq = new SquareStack();
        List<Square> currentSelectedStack = new List<Square>();

        bool started = false;
        int move = 20;
        int score = 0;
        Color lastItem;

        public Form1()
        {
            InitializeComponent();
            colorare();
            MOVE.Visible = false;
            SCORE.Visible = false;
        }

        private void colorare()
        {
            for (int i = 0; i < 7; i++)
                for (int ii = 0; ii < 7; ii++)
                {
                    Square p = ((Square)(game_zone.GetControlFromPosition(i, ii)));
                    sq.register(p);

                    p.MouseEnter += game_zone_MouseHover;

                    int type = RandSingl.rand.Next(1, 4);
                    switch (type)
                    {
                        case 1:
                            {
                                p.BackColor = Color.Red;
                                RedSquare rs = new RedSquare();

                                p = rs;
                            }; break;
                        case 2: 
                            {
                                p.BackColor = Color.Cyan;
                                CyanSquare cs = new CyanSquare();

                                p = cs;
                            }; break;
                        case 3: 
                            {
                                p.BackColor = Color.Lime;
                                LimeSquare ls = new LimeSquare();

                                p = ls;
                            }; break;
                    }
                }
        }

        private void game_run_Tick(object sender, EventArgs e)
        {
        }

        private void game_zone_MouseHover(object sender, EventArgs e)
        {
            if (started == true)
            {
                Square selected_tab = (Square)sender;

                if (selected_tab.BackColor != lastItem && currentSelectedStack.Count > 0)
                {
                    if (currentSelectedStack.Count >= 3)
                    {
                        foreach (Square item in currentSelectedStack)
                        {
                            TableLayoutPanelCellPosition position = game_zone.GetPositionFromControl(item);
                            Square current_sq = ((Square)(game_zone.GetControlFromPosition(position.Column, position.Row)));
                            sq.notify(current_sq);
                        }
                        score += currentSelectedStack.Count;
                        this.SCORE.Text = "SCORE: " + score;

                        move--;
                        this.MOVE.Text = "MOVE: " + move;
                        if (move == 0) end();
                    }
                    reset_border();
                }

                if (currentSelectedStack.Count == 0)
                {
                    currentSelectedStack.Add(selected_tab);
                    int position_x = System.Convert.ToInt32(game_zone.Controls.IndexOf(selected_tab)) / 7;
                    int position_y = System.Convert.ToInt32(game_zone.Controls.IndexOf(selected_tab)) - 7 * position_x;
                    ((Square)(game_zone.GetControlFromPosition(position_y, position_x))).BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    lastItem = selected_tab.BackColor;
                }

                if (selected_tab.BackColor == lastItem && currentSelectedStack.Count > 0)
                {
                    if (currentSelectedStack.Contains(selected_tab) == false) currentSelectedStack.Add(selected_tab);
                    int position_x = System.Convert.ToInt32(game_zone.Controls.IndexOf(selected_tab)) / 7;
                    int position_y = System.Convert.ToInt32(game_zone.Controls.IndexOf(selected_tab)) - 7 * position_x;
                    ((Square)(game_zone.GetControlFromPosition(position_y, position_x))).BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    lastItem = selected_tab.BackColor;
                }
            }
        }

        private void end()
        {
            move = 20;
            score = 0;
            this.BUTTON_START.Visible = true;
            this.MOVE.Visible = false;
        }
        private void reset_border()
        {
            currentSelectedStack.Clear();
            for (int i = 0; i < 7; i++)
                for (int ii = 0; ii < 7; ii++)
                    ((Square)(game_zone.GetControlFromPosition(i, ii))).BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void BUTTON_START_Click(object sender, EventArgs e)
        {
            started = true;
            SCORE.Visible = true;
            MOVE.Visible = true;
            BUTTON_START.Visible = false;
            this.SCORE.Text = "SCORE: " + 0;
            this.MOVE.Text = "MOVE: " + 20;
        }
    }
}
