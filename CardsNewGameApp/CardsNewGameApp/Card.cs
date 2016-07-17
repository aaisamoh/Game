using Xamarin.Forms;

namespace CardsNewGameApp
{

    public class Card
    {
       
        public int CardId { get; set; }
        public int CardValue { get; set; }
        public bool isSelectedCard { get; set; }   
        public bool  isVisibleImage { get; set; }
      



        //public List<CardViewModel> AddCards()
        //{
        //    Random rand = new Random();
        //     Cards = new List<CardViewModel>()
        //    {
        //        new CardViewModel 
        //        { 
        //             CardId=1, Selected=false, CardValue=rand.Next(1,12)
        //        },
        //        new CardViewModel
        //        {
        //             CardId=2, Selected=false, CardValue=rand.Next(1,12)
        //        },
        //         new CardViewModel
        //        {
        //             CardId=3, Selected=false, CardValue=rand.Next(1,12)
        //        },
        //        new CardViewModel
        //        {
        //             CardId=4, Selected=false, CardValue=rand.Next(1,12)
        //        },
        //         new CardViewModel
        //        {
        //             CardId=5, Selected=false, CardValue=rand.Next(1,12)
        //        },
        //        new CardViewModel
        //        {
        //             CardId=6, Selected=false, CardValue=rand.Next(1,12)
        //        },
        //         new CardViewModel
        //        {
        //             CardId=7, Selected=false, CardValue=rand.Next(1,12)
        //        },
        //        new CardViewModel
        //        {
        //             CardId=8, Selected=false, CardValue=rand.Next(1,12)
        //        },
        //         new CardViewModel
        //        {
        //             CardId=9, Selected=false, CardValue=rand.Next(1,12)
        //        },
        //        new CardViewModel
        //        {
        //             CardId=10, Selected=false, CardValue=rand.Next(1,12)
        //        }, new CardViewModel
        //        {
        //             CardId=11, Selected=false, CardValue=rand.Next(1,12)
        //        },
        //        new CardViewModel
        //        {
        //             CardId=12, Selected=false, CardValue=rand.Next(1,12)
        //        }
        //    };
        //    
        //}  

    }
}
