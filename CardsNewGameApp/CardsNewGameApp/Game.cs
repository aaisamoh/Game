using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CardsNewGameApp
{
    public static class Game
    {
        // start new game
      
        public static List<Player> GetPlayerData()
        {
            return new List<Player>{
                new Player()
               {
                  PlayerId = 1,
                  Name = "Issa"
                }
            };
        }
        public static List<Card> GetCardsData()
        {            
            Random rand = new Random();         

            return new List<Card>(){

            new Card {
                    CardId=1, isSelectedCard=true, CardValue=rand.Next(1,10), isVisibleImage=true
                },
                new Card()
                {
                     CardId=2, isSelectedCard=true, CardValue=rand.Next(1,10), isVisibleImage=true
                },
                 new Card()
                {
                     CardId=3, isSelectedCard=true, CardValue=rand.Next(1,10), isVisibleImage=true
                },
                new Card()
                {
                     CardId=4, isSelectedCard=true, CardValue=rand.Next(1,10), isVisibleImage=true
                },
                 new Card()
                {
                     CardId=5, isSelectedCard=true, CardValue=rand.Next(1,10), isVisibleImage=true
                },
                new Card()
                {
                     CardId=6, isSelectedCard=true, CardValue=rand.Next(1,10), isVisibleImage=true
                },
                 new Card()
                {
                     CardId=7, isSelectedCard=true, CardValue=rand.Next(1,10), isVisibleImage=true
                },
                new Card()
                {
                     CardId=8, isSelectedCard=true, CardValue=rand.Next(1,10), isVisibleImage=true
                },
                 new Card()
                {
                     CardId=9, isSelectedCard=true, CardValue=rand.Next(1,10), isVisibleImage=true
                },
                new Card()
                {
                     CardId=10, isSelectedCard=true, CardValue=rand.Next(1,10), isVisibleImage=true
                }, new Card()
                {
                     CardId=11, isSelectedCard=true, CardValue=rand.Next(1,10), isVisibleImage=true
                },
                new Card()
                {
                     CardId=12, isSelectedCard=true, CardValue=rand.Next(1,10), isVisibleImage=true
                }
            };

            //for (var i = 1; i <= MAX_CARDS; i++)
            //    Cards.Add(new Card
            //    {
            //        CardId = i,
            //        Selected = false,
            //        CardValue = rand.Next(1, 12),
            //        IsVisibleImage = false,
            //        ImagePath = path
            //    });
           
        }

        private static void tapImage_Tapped(object sender, EventArgs e)
        {
            // handle the tap  
            //DisplayAlert("Alert", "This is an image button", "OK");
        }

       
    }

  }
