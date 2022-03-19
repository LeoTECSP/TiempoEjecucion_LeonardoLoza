using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiempoEjecucion_LeonardoLoza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Cajas de Texto
            TextBox cajaTextoNombre = new TextBox();
            TextBox cajaTexto2AM = new TextBox();
            TextBox cajaTextoAP = new TextBox();
            TextBox cajaTextoCURP = new TextBox();
            TextBox cajaTextoDireccion = new TextBox();
            TextBox cajaTextoEstado = new TextBox();
            TextBox cajaTextoNumeroCorreo = new TextBox();
            TextBox cajaTextoSemestre = new TextBox();
            TextBox cajaTextoPromedio = new TextBox();
            TextBox cajaTextoNombreEscuela = new TextBox();
    


            cajaTextoNombre.Name = "txtBoxNombre";
            cajaTextoNombre.Location = new Point(100, 30);

            cajaTextoNombre.Height = 80;
            cajaTextoNombre.Width = 100;

            cajaTexto2AM.Name = "txtBoxApellidoMaterno";
            cajaTexto2AM.Location = new Point(100, 60);
            cajaTexto2AM.Height = 80;
            cajaTexto2AM.Width = 100;

            cajaTextoAP.Name = "txtBoxApellidoPaterno";
            cajaTextoAP.Location = new Point(100, 90);
            cajaTextoAP.Height = 80;
            cajaTextoAP.Width = 100;

            cajaTextoCURP.Name = "txtBoxCURP";
            cajaTextoCURP.Location = new Point(100, 120);
            cajaTextoCURP.Height = 80;
            cajaTextoCURP.Width = 100;


            this.Controls.Add(cajaTextoNombre);
            this.Controls.Add(cajaTexto2AM);
            this.Controls.Add(cajaTextoAP);
            this.Controls.Add(cajaTextoCURP);

            #endregion

            #region Textos
            Label Indicacion = new Label();
            Label Nombre = new Label();
            Label ApellidoMaterno = new Label();
            Label ApellidoPaterno = new Label();
            Label CURP = new Label();
            Label Genero = new Label();
            Label EstadoCivil = new Label();

            EstadoCivil.Name = "lblEstadoCivil";
            EstadoCivil.Location = new Point(0,200);
            EstadoCivil.Text = "Estado Civil:";

            Genero.Name = "lblGenero";
            Genero.Location = new Point(0,150);
            Genero.Text = "Genero:";

            Indicacion.Name = "lblIndicadorRegistro";
            Indicacion.Location = new Point(100, 0);
            Indicacion.Font = new Font("Arial", 14, FontStyle.Bold);
            Indicacion.Text = "Registro";


            Nombre.Name = "lblNombre";
            ApellidoMaterno.Name = "lblApellidoMaterno";
            ApellidoPaterno.Name = "lblNombre";
            CURP.Name = "lblCURP";

            Nombre.Location = new Point(0, 30);
            ApellidoMaterno.Location = new Point(0, 60);
            ApellidoPaterno.Location = new Point(0, 90);
            CURP.Location = new Point(0, 120);

            Nombre.Text = "Nombre:";
            ApellidoMaterno.Text = "Apellido Materno:";
            ApellidoPaterno.Text = "Apellido Paterno:";
            CURP.Text = "CURP:";

            this.Controls.Add(Nombre);
            this.Controls.Add(ApellidoMaterno);
            this.Controls.Add(ApellidoPaterno);
            this.Controls.Add(CURP);
            this.Controls.Add(Indicacion);
            this.Controls.Add(Genero);
            this.Controls.Add(EstadoCivil);
            #endregion

            #region Botones en Círculo
            RadioButton Masculino = new RadioButton();
            RadioButton Femenino = new RadioButton();
            RadioButton OtroGenero = new RadioButton();

            Masculino.Name = "rbMasculino";
            Femenino.Name = "rbFemenino";
            OtroGenero.Name = "rbOtroGenero";

            Masculino.AutoSize = true;
            Femenino.AutoSize = true;
            OtroGenero.AutoSize = true;

            Masculino.Text = "Masculino";
            Femenino.Text = "Femenino";
            OtroGenero.Text = "Otro Género";

            Masculino.Location = new Point(100,150);
            Femenino.Location = new Point(200, 150);
            OtroGenero.Location = new Point(300, 150);


            this.Controls.Add(Masculino);
            this.Controls.Add(Femenino);
            this.Controls.Add(OtroGenero);

            #endregion


            ListView vistaEstadoCivil = new ListView();

            

            vistaEstadoCivil.Height = 40;
            vistaEstadoCivil.Width = 100;

            vistaEstadoCivil.Location = new Point(100,200);

            vistaEstadoCivil.Items.Add("Soltero/a");
            vistaEstadoCivil.Items.Add("Casado/a");
            vistaEstadoCivil.Items.Add("Divorciado/a");

            this.Controls.Add(vistaEstadoCivil);

        }

        
    }
}