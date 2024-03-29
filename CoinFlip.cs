namespace CoinFlipGame
{
    public partial class CoinFlipGame : Form
    {

        int heads = 0;
        int tails = 0;
        public CoinFlipGame()
        {
            InitializeComponent();
        }

        private void CoinFlipButton_Click(object sender, EventArgs e)
        {
            Random coinFlip = new Random();
            int result = coinFlip.Next(1, 3);

            if (result == 1)
            {
                CoinImage.ImageLocation = @"C:\Users\Wojtek\Desktop\ZDJ, PDF ITP\branding.png";
                CoinImage.SizeMode = PictureBoxSizeMode.StretchImage;
                heads++;
                HeadsLabel.Text = $"Heads: {heads}";
            }
            else
            {
                CoinImage.ImageLocation = @"C:\Users\Wojtek\Desktop\ZDJ, PDF ITP\ai.png";
                CoinImage.SizeMode = PictureBoxSizeMode.StretchImage;
                tails++;
                TailsLabel.Text = $"Tails: {tails}";
            }
        }
    }
}