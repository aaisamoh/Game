
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CardsNewGameApp
{
    public class CardViewPage : ContentPage
    {
        private List<Card> cc = Game.GetCardsData();
        private static string[] ImagesPath={"C0.png", "C1.png", "C2.png", "C3.png", "C4.png",
            "C5.png", "C6.png", "C7.png", "C8.png", "C9.png", "C10.png"};
        private int NewValue1=0, NewValue2=0,incrmt=0;
        private static object Result=0;
        //private static bool isEnable1 =true, isEnable2 = true;
        //private static bool isSelected1 = true, isSelected2 = true;
        private static Image Removeimg;
        //private Object navigationProperty;
        private Label ScoreLbl;
        private Grid grid;
        private Image image;
        private StackLayout ScoreLayout;
        private Button backButton;

        public CardViewPage()
        {
            
            Title = "Game page";
            Padding = new Thickness(5, Device.OnPlatform(20, 5, 0), 5, 0);

            Label lbl = new Label
            {
                Text="Payer score:",
                HorizontalOptions =LayoutOptions.Start
            };
              ScoreLbl = new Label
            {
                Text = "0",
                 HorizontalOptions = LayoutOptions.Start
                ,
                  BackgroundColor=Color.Red
                , TextColor=Color.White
            };
            ScoreLayout = new StackLayout
            {
                Orientation= StackOrientation.Horizontal,
                Children = {lbl,ScoreLbl},
                Padding=new Thickness(2,2,0,5)
            };
           backButton = new Button
            {
                Text = "Back to the main page",              
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                BackgroundColor=Color.Red
            };
            //go back to main page
            backButton.Clicked += async (s, a) =>
            {
                await Navigation.PopAsync();

            };

            incrmt = 0;
            SaveAndGetImagesToList.init();
          
            DrawImages();//initial image

                  
            Content = new StackLayout
            {
                VerticalOptions=LayoutOptions.CenterAndExpand,
                HorizontalOptions=LayoutOptions.CenterAndExpand,

                Children = {
                  ScoreLayout, grid,backButton
                }
            };
           
        }

        private async void tapImage_Tapped(object sender, EventArgs e)
        {

            var row = (int)((BindableObject)sender).GetValue(Grid.RowProperty);
            var col = (int)((BindableObject)sender).GetValue(Grid.ColumnProperty);

            var NewValue = (object)((BindableObject)sender).GetValue(Image.BindingContextProperty);//Get value of card
            var IsEnable = (bool)((BindableObject)sender).GetValue(Image.IsEnabledProperty);//Get enable value
            var IsSelected = (bool)((BindableObject)sender).GetValue(Image.IsVisibleProperty);//Get  visible value
            var classId = (string)((BindableObject)sender).GetValue(Image.ClassIdProperty);//Get  visible value

            var bb = ImagesPath[int.Parse(NewValue.ToString())];
            ((BindableObject)sender).SetValue(Image.SourceProperty, bb);//set the new source for card
            ((BindableObject)sender).SetValue(Image.IsEnabledProperty, false);//set the new  enable property for  card
            incrmt++;
            if (incrmt >= 3) incrmt = 0;

            if (incrmt == 1)
            {
                NewValue1 = int.Parse(NewValue.ToString());

                Removeimg = SaveAndGetImagesToList.GetImageFromList(row, col);//get image  from list
            }
            if (incrmt == 2) { NewValue2 = int.Parse(NewValue.ToString()); incrmt = 0; }



            try
            {


                if (NewValue1 > 0 && NewValue2 > 0)
                {
                    if (NewValue1.Equals(NewValue2))
                    {
                        Result = ScoreLbl.GetValue(Label.TextProperty);// Get the value from label text                        
                        ScoreLbl.SetValue(Label.TextProperty, int.Parse(Result.ToString()) + 1);// increase the result that is in label and show it in label                            
                    }
                    NewValue1 = 0; NewValue2 = 0;
                    await Task.Delay(1500);
                    ((BindableObject)sender).SetValue(Image.IsVisibleProperty, false);//set the new  enable property for  card
                    grid.Children.Remove(Removeimg);
                    incrmt = 0;

                }
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
        }

        private void DrawImages(int CardNum = 0)
        {
            var i = 0;//row
            var j = 0;//column
            //grid.Children.Clear();
            grid = new Grid();
               foreach (var z in cc)
            {
                //if (z.isSelectedCard) CardNum = 0;
                //else CardNum = z.CardValue;
                //Create a new card
                image = new Image
                {
                    Source = ImagesPath[CardNum],
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,                
                    IsVisible = true,
                    IsEnabled=true,
                    ClassId = z.CardId.ToString(),
                    BindingContext = z.CardValue
                };
               
                //Creating TapGestureRecognizers  
                var tapImage = new TapGestureRecognizer();
                //Binding events  
                tapImage.Tapped += tapImage_Tapped;
                //Associating tap events to the image buttons  
                image.GestureRecognizers.Add(tapImage);

                if (j <= 3)
                {
                    grid.Children.Add(image, j, i);
                    SaveAndGetImagesToList.AddNewIems(i, j, image);//add new image with its coordinate
                    j++;
                }
                else
                {
                    i = i + 1;

                    j = 0;
                    SaveAndGetImagesToList.AddNewIems(i, j, image);//add new image with its coordinate
                    grid.Children.Add(image, j, i);
                    j = 1;
                }
            }
           

        }
    }
}
