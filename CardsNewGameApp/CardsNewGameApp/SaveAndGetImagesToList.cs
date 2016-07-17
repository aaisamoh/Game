using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace CardsNewGameApp
{
    public static class SaveAndGetImagesToList
    {
        public static ObservableCollection<ImagesToList> imagetolist; 

        public static void init()
        {
            imagetolist = new ObservableCollection<ImagesToList>();
        }
        public static void AddNewIems(int row,int col,Image image)
        {
            imagetolist.Add(new ImagesToList() {  row=row,col=col, image=image });

        }
        public static Image GetImageFromList(int row, int col)
        {
           var img= imagetolist.Where(a => a.col == col && a.row == row).Select(s => s.image).FirstOrDefault();
            return img;
        }
    }
}
