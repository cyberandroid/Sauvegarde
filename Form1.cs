using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;


namespace Sauvegarde
{
    public partial class Form1 : Form
    {
        private string cheminDossier1 = "";
        private string cheminSauvegarde = "";
        protected static readonly ILog log = LogManager.GetLogger(typeof(Program));

        public Form1()
        {
            InitializeComponent();
            lblresultat.Text = "";

        }

        private void btnParcourir1_Click(object sender, EventArgs e)
        {
            folderFchier1.ShowDialog();

            this.cheminDossier1 = folderFchier1.SelectedPath;
            if (this.cheminDossier1 != "")
            {

                txtchemin1.Text = this.cheminDossier1;

            }
           
            //nomdossier 
           /* FileInfo info = new FileInfo(this.cheminDossier1);
            string nomdossier = info.Name;
            MessageBox.Show(nomdossier);*/


            //on rempli les dossiers selectionné dans la listbox
            listeDossiers.Items.Add(this.cheminDossier1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        private void btnSauvegarde_Click(object sender, EventArgs e)
        {
            string dossierSauvegarde = txtdestination.Text;  //@"D:\Sauvegarde Archive"


            if (listeDossiers.Items.Count == 0) //litbox vide car contient 0 element
            {
                lblresultat.Text = "Merci de renseigner un ou plusieurs dossiers";
                lblresultat.ForeColor = Color.Red;
            }
            else if (dossierSauvegarde == "Sélectionner un dossier")  //l'utilisateur n'a pas saisie un repertoire de destination              
            {

                lblresultat.Text = "Merci de renseigner répertoire de déstination";
                lblresultat.ForeColor = Color.Red;
                log.Info("Repertoire de destination vide  : " + dossierSauvegarde);
            }
            else
            {
                foreach (string EnsembleDossier in listeDossiers.Items)
                {
                    CompressMsdn(EnsembleDossier, dossierSauvegarde);

                }
                Effacer();
                //TODO tout s'est bien passé : ouvrir dossier de destination
                try
                {
                    Process.Start(dossierSauvegarde);
                }
                catch (Exception erreurOuverture)
                {
                    log.Info("ouverture du dossier failed  : " + erreurOuverture.ToString());

                }



            }
        }

        private void CompressMsdn(string dossier, string destination)
        {
            log.Info("****** DEBUT DE LA COMPRESSION *****");
            DirectoryInfo dirInfo = new DirectoryInfo(dossier);
            string name = dirInfo.Name;
            log.Info("Chemin du dossier : " + dossier);
            log.Info("Nom du dossier : " + name);


            try
            {
                DateTime madate = DateTime.Now;
                string date = madate.ToString("dd_MM_yyyy_HH_mm_ss");


                string repertoireFinal = destination + "\\" + name + "_" + date + ".rar";
                log.Info("Repertoire de destination  : " + repertoireFinal);


                System.IO.Compression.ZipFile.CreateFromDirectory(dossier, repertoireFinal, CompressionLevel.Optimal, true);

                lblresultat.Text = "Succès de la compréssion des dossiers.";
                lblresultat.ForeColor = Color.Green;


            }
            catch (Exception erreur)
            {
                log.Error("Erreur dans la compression " + erreur.Message);

            }

        }

        private void listeDossiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            log.Info("Element selectionné pour la suppression : " + listeDossiers.SelectedItem);
            listeDossiers.Items.Remove(listeDossiers.SelectedItem);
        }


        private void Effacer()
        {
            txtchemin1.Text = "";
            //mise à vide des chemin
            this.cheminDossier1 = "";


            listeDossiers.Items.Clear();
        }


        private void btnDestination_Click(object sender, EventArgs e)
        {
            FolderRepDest.ShowDialog();

            this.cheminSauvegarde = FolderRepDest.SelectedPath;
            if (this.cheminSauvegarde != "")
            {

                txtdestination.Text = this.cheminSauvegarde;

            }
        }
    }
}
