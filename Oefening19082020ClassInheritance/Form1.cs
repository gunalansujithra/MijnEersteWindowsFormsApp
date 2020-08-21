using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening19082020ClassInheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<MusicAlbum> album = new List<MusicAlbum>();
        private void Form1_Load(object sender, EventArgs e)
        {
            MusicAlbum music1 = new MusicAlbum("Thriller", 4.5, new List<string>() { "Guitar", "Drums" });
            MusicAlbum music2 = new MusicAlbum("Rubber Soul", 5);
            MusicAlbum instrument1 = new Publisher("Sky Blue Sky", 3.8, 2000, new List<string>() { "Piano", "Drums" });
            MusicAlbum instrument2 = new Publisher("Unearthed", 4.3, 2010);
            MusicAlbum artist1 = new Artist("Smile", 4.6, "Brian", new List<string>() { "Violin" });
            MusicAlbum artist2 = new Artist("The Eminen Show", 3.9, "Eminen");
            MusicAlbum singer1 = new Singer("Gold", 4.4, "Ryan", 8, new List<string>() { "Trumpet" });
            MusicAlbum singer2 = new Singer("Neon Bible", 5, "Arcade", 7);
            MusicAlbum composer1 = new Composer("The Woods", 3.5, "Kenny", "Modern", new List<string>() { "Keyboard" });
            MusicAlbum composer2 = new Composer("Come Away With Me", 4.2, "Norra", "Classical");

            album.Add(music1);
            album.Add(music2);
            album.Add(instrument1);
            album.Add(instrument2);
            album.Add(artist1);
            album.Add(artist2);
            album.Add(singer1);
            album.Add(singer2);
            album.Add(composer1);
            album.Add(composer2);

            lbAlbum.Items.Add("Iedereen");
            lbAlbum.Items.Add("Artist");
            lbAlbum.Items.Add("Publisher");
        }        

        private void lbMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            MusicAlbum selectedAlbum = (MusicAlbum)lbMusic.SelectedItem;

            if (lbMusic.DataSource != null)
            {
                lblMusic.Text = selectedAlbum.Beschrijf();
            }
            else
            {
                lblMusic.Text = "";
            }
        }

        private void lbAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lbAlbum.SelectedItem.ToString())
            {
                case "Artist":
                    List<Artist> artist = new List<Artist>();

                    foreach (var item in album.OfType<Artist>())
                    {
                        artist.Add(item);
                    }

                    lbMusic.DataSource = null;
                    lbMusic.DataSource = artist;
                    break;

                case "Publisher":
                    List<Publisher> publisher = new List<Publisher>();

                    foreach (var item in album.OfType<Publisher>())
                    {
                        publisher.Add(item);
                    }

                    lbMusic.DataSource = null;
                    lbMusic.DataSource = publisher;
                    break;

                default:
                case "Iedereen":
                    lbMusic.DataSource = null;
                    lbMusic.DataSource = album;
                    break;
            }
        }
    }
}
