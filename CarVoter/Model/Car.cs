using System.Windows.Media.Imaging;

namespace CarVoter.Model
{
    class Car
    {
        public BitmapImage Image { get; set; }
        public string Title  { get; set; }
        public string Description { get; set; }
        public int NumDownVotes { get; set; }
        public int NumUpVotes { get; set; }
        public int KiloWats  { get; set; }
    }
}
