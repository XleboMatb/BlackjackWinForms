using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace blackjack2
{

    public partial class mainForm : Form
    {
        bool playerGetsAcard;
        int playerScore,dillerScore = 0;
        int counter = 0;
        PictureBox hiddenCard = new PictureBox();
        List<PictureBox> playerCards = new List<PictureBox>();
        List<PictureBox> dillerCards = new List<PictureBox>();
        List<Cards> mainCardsDeck = new List<Cards>();
        Random random = new Random();
        public mainForm()
        {
            InitializeComponent();
            getACardButton.Visible = false;
            endTurnButton.Visible = false;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            playButton.Visible = false;
            getACardButton.Visible = true;
            endTurnButton.Visible = true;
            if (counter > 0)
            {
                GetFirstTwoCards();
                return;
            }
            else
            {
                mainCardsDeck = GetCardsDeck();
                GetFirstTwoCards();
                counter++;
                return;
            }
        }
        private List<Cards> GetCardsDeck()
        {
            List<Cards> cardsDeck = new List<Cards>();
            for (int i = 0; i < Cards.cardsDeck.Count; i++)
            {
                cardsDeck.Add(Cards.cardsDeck[i]);
            }
            return cardsDeck;
        }
        private void GetFirstTwoCards()
        {
            if (mainCardsDeck.Count < 4)
            {
                counter = 0;
                MessageBox.Show("карт нехватает для продолжения игры");
                MessageBox.Show("собираем карты ещё раз");
                mainCardsDeck = GetCardsDeck();
                GetFirstTwoCards();
                counter++;
                return;
            }
            else
            {
                //карты игрока
                for (int i = 0; i <= 1; i++)
                {
                    int randomCardIndex = random.Next(0, mainCardsDeck.Count - 1);
                    playerCards.Add(new PictureBox());
                    playerCards[i].Size = new Size(110, 169);
                    playerCards[i].Image = mainCardsDeck[randomCardIndex].cardsPic;
                    playerCards[i].Location = new Point(((this.Width / 2) - playerCards[i].Width) + playerCards[i].Width * i, this.Height - playerCards[i].Height);
                    this.Controls.Add(playerCards[i]);
                    playerScore = playerScore + mainCardsDeck[randomCardIndex].cardValue;
                    mainCardsDeck.Remove(mainCardsDeck[randomCardIndex]); //диллер не сможет взять данную карту, она вышла из колоды 
                }
                playerScoreLabel.Text = playerScore.ToString();
                //карты диллера
                for (int i = 0; i <= 1; i++)
                {
                    int randomCardIndex = random.Next(0, mainCardsDeck.Count - 1);
                    dillerCards.Add(new PictureBox());
                    dillerCards[i].Size = new Size(110, 169);
                    dillerCards[i].Image = mainCardsDeck[randomCardIndex].cardsPic;
                    dillerCards[i].Location = new Point(((this.Width / 2) - dillerCards[i].Width) + dillerCards[i].Width * i, dillerCards[i].Height - 150);
                    this.Controls.Add(dillerCards[i]);
                    dillerScore = dillerScore + mainCardsDeck[randomCardIndex].cardValue;
                    mainCardsDeck.Remove(mainCardsDeck[randomCardIndex]); //больше эту карту не получиться взять. 
                }

                hiddenCard.Image = Cards.cardsDeck[Cards.cardsDeck.Count - 1].cardsPic;
                this.Controls.Add(hiddenCard);
                hiddenCard.Show();
                hiddenCard.BringToFront();
                hiddenCard.Size = new Size(110, 169);
                hiddenCard.Location = new Point(((this.Width / 2) - dillerCards[0].Width) + dillerCards[0].Width * 0, dillerCards[0].Height - 150);
                amountOfCardsInDeckLabel.Text = "осталось карт в колоде: " + (mainCardsDeck.Count - 1).ToString();
                if (playerScore == 21 | dillerScore == 21)
                {
                    hiddenCard.Hide();
                    WinCondition();

                }
                else
                {

                }

            }

        }
        private void getACard()
        {
            if (mainCardsDeck.Count <= 0)
            {
                WinCondition();
            }
            else
            {
                if (playerGetsAcard == true & mainCardsDeck.Count > 0)
                {
                    playerCards.Add(new PictureBox());

                    for (int i = playerCards.Count - 1; i < playerCards.Count; i++)
                    {
                        int randomCardIndex = random.Next(0, mainCardsDeck.Count - 1);
                        playerCards[i].Size = new Size(110, 169);
                        playerCards[i].Image = mainCardsDeck[randomCardIndex].cardsPic;
                        playerCards[i].Location = new Point(((this.Width / 2) - playerCards[i].Width) + playerCards[i].Width * i, this.Height - playerCards[i].Height);
                        this.Controls.Add(playerCards[i]);
                        playerScore = playerScore + mainCardsDeck[randomCardIndex].cardValue;
                        mainCardsDeck.Remove(mainCardsDeck[randomCardIndex]); //диллер не сможет взять данную карту, она вышла из колоды 
                    }
                    playerScoreLabel.Text = playerScore.ToString();
                    if (playerScore > 21)
                    {
                        WinCondition();
                        return;
                    }
                    else
                    {

                    }
                }
                else
                {
                    dillerCards.Add(new PictureBox());
                    for (int i = dillerCards.Count - 1; i < dillerCards.Count; i++)
                    {
                        if (dillerScore <= 15)
                        {
                            if (mainCardsDeck.Count <= 0)
                            {
                                WinCondition();
                            }
                            else
                            {

                                int randomCardIndex = random.Next(0, mainCardsDeck.Count - 1);
                                dillerCards[i].Size = new Size(110, 169);
                                dillerCards[i].Image = mainCardsDeck[randomCardIndex].cardsPic;
                                dillerCards[i].Location = new Point(((this.Width / 2) - dillerCards[i].Width) + dillerCards[i].Width * i, dillerCards[i].Height - 150);
                                this.Controls.Add(dillerCards[i]);
                                dillerScore = dillerScore + mainCardsDeck[randomCardIndex].cardValue;
                                mainCardsDeck.Remove(mainCardsDeck[randomCardIndex]); //диллер не сможет взять данную карту, она вышла из колоды 
                            }
                        }
                        else
                        {
                            WinCondition();
                            break;
                        }
                    }
                    if (dillerScore > 21)
                    {
                        WinCondition();
                        return;
                    }
                    else
                    {
                        WinCondition();
                    }
                }
            }

            
            amountOfCardsInDeckLabel.Text = "осталось карт в колоде: " + (mainCardsDeck.Count - 1).ToString();
            playerGetsAcard = false;
        }

        private void getACardButton_Click(object sender, EventArgs e)
        {
            if (mainCardsDeck.Count <= 0)
            {
                GetFirstTwoCards();
                return;
            }
            else
            {
                playerGetsAcard = true;
                getACard();
            }
        }

        private void Reset()
        {
            playerCards.Clear();
            dillerCards.Clear();
        }
        private void WinCondition()
        {
            hiddenCard.Hide();
            if (dillerScore <= 15 & mainCardsDeck.Count != 0 & mainCardsDeck.Count > 0)
            {
                playerGetsAcard = false;
                getACard();
            }
            else
            {
                if (dillerScore < playerScore & playerScore < 22 & dillerScore < 21 | playerScore == 21 & dillerScore != 21 | dillerScore > playerScore & dillerScore > 21)
                {
                    MessageBox.Show("you won");
                }
                else if (dillerScore > playerScore)
                {
                    MessageBox.Show("you lost!");
                }
                else if (dillerScore > playerScore & dillerScore < 21 | playerScore > 21 | dillerScore == 21 & playerScore == 21 | dillerScore == 21 & playerScore != 21)
                {
                    MessageBox.Show("you lost!");
                }
                else if (dillerScore == playerScore)
                {
                    MessageBox.Show("tie");
                }
                amountOfCardsInDeckLabel.Text = "осталось карт в колоде: " + (mainCardsDeck.Count - 1).ToString();
                dillerScore = 0;
                playerScore = 0;
                playerScoreLabel.Text = playerScore.ToString();
                playButton.Visible = true;
                getACardButton.Visible = false;
                endTurnButton.Visible = false;
                for (int i = 0; i < playerCards.Count; i++)
                {
                    this.Controls.Remove(playerCards[i]);
                }
                for (int i = 0; i < dillerCards.Count; i++)
                {
                    this.Controls.Remove(dillerCards[i]);
                }
                Reset();
            }
            
        }

        private void endTurnButton_Click(object sender, EventArgs e)
        {
            hiddenCard.Visible = false;
            WinCondition();
        }
    }
}
