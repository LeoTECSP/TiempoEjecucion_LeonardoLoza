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
        GeneracionBeca AccederBeca = new GeneracionBeca();
        public static string NombrePersona;

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
            TextBox cajaTextoCorreoElectronico = new TextBox();
            TextBox cajaTextoPromedio = new TextBox();
            TextBox cajaTextoNombreEscuela = new TextBox();
            TextBox cajaTextoNumeroTelefono = new TextBox();
    


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
            cajaTextoCURP.Width = 120;

            cajaTextoDireccion.Name = "txtBoxDireccion";
            cajaTextoDireccion.Location = new Point(100, 250);
            cajaTextoCURP.Height = 80;
            cajaTextoCURP.Width = 130;

            cajaTextoEstado.Name = "txtEstadoPersona";
            cajaTextoEstado.Location = new Point(100, 280);
            cajaTextoCURP.Height = 80;
            cajaTextoCURP.Width = 100;

            cajaTextoNumeroTelefono.Name = "txtNumeroTelefono";
            cajaTextoNumeroTelefono.Location = new Point(100, 310);
            cajaTextoNumeroTelefono.Height = 80;
            cajaTextoNumeroTelefono.Width = 110;

            cajaTextoCorreoElectronico.Name = "txtCorreoElectronico";
            cajaTextoCorreoElectronico.Location = new Point(320,30);
            cajaTextoCorreoElectronico.Height = 80;
            cajaTextoCorreoElectronico.Width = 140;

            cajaTextoNombreEscuela.Name = "txtNombreEscuela";
            cajaTextoNombreEscuela.Location = new Point(320,180);
            cajaTextoNombreEscuela.Height = 80;
            cajaTextoNombreEscuela.Width = 100;
          

            this.Controls.Add(cajaTextoNombre);
            this.Controls.Add(cajaTexto2AM);
            this.Controls.Add(cajaTextoAP);
            this.Controls.Add(cajaTextoCURP);
            this.Controls.Add(cajaTextoDireccion);
            this.Controls.Add(cajaTextoEstado);
            this.Controls.Add(cajaTextoNumeroTelefono);
            this.Controls.Add(cajaTextoCorreoElectronico);
            this.Controls.Add(cajaTextoNombreEscuela);
            #endregion

            #region Textos
            Label Indicacion = new Label();
            Label Nombre = new Label();
            Label ApellidoMaterno = new Label();
            Label ApellidoPaterno = new Label();
            Label CURP = new Label();
            Label Genero = new Label();
            Label EstadoCivil = new Label();
            Label DireccionPersona = new Label();
            Label EstadoNacimiento = new Label();
            Label NumeroTelefono = new Label();
            Label CorreoElectronico = new Label();
            Label Promedio = new Label();
            Label Escuela = new Label();

            Escuela.Name = "lblEscuela";
            Escuela.Location = new Point(250, 180);
            Escuela.Text = "Escuela:";
            Escuela.AutoSize = true;

            Promedio.Name = "lblPromedio";
            Promedio.Location = new Point(250, 70);
            Promedio.Text = "Promedio actual:";
            Promedio.AutoSize = true;

            CorreoElectronico.Name = "lblCorreoElectronico";
            CorreoElectronico.Location = new Point(250, 30);
            CorreoElectronico.Text = "Correo \nElectrónico:";
            CorreoElectronico.AutoSize = true;

            NumeroTelefono.Name = "lblNumeroTelefono";
            NumeroTelefono.Location = new Point(0, 310);
            NumeroTelefono.AutoSize = true;
            NumeroTelefono.Text = "Numero de teléfono:";


            EstadoNacimiento.Name = "lblEstadoNacimiento";
            EstadoNacimiento.Location = new Point(0, 280);
            EstadoNacimiento.Text = "Estado:";


            DireccionPersona.Name = "lblDireccionPersona";
            DireccionPersona.Location = new Point(0,250);
            DireccionPersona.Text = "Dirección:";


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
            this.Controls.Add(DireccionPersona);
            this.Controls.Add(EstadoNacimiento);
            this.Controls.Add(NumeroTelefono);
            this.Controls.Add(CorreoElectronico);
            this.Controls.Add(Promedio);
            this.Controls.Add(Escuela);
            #endregion

            #region Botones en Círculo
            RadioButton Masculino = new RadioButton();
            RadioButton Femenino = new RadioButton();
            RadioButton OtroGenero = new RadioButton();
            RadioButton PromedioNormal = new RadioButton();
            RadioButton PromedioExcelencia = new RadioButton();

            Masculino.Name = "rbMasculino";
            Femenino.Name = "rbFemenino";
            OtroGenero.Name = "rbOtroGenero";

            Masculino.AutoSize = true;
            Femenino.AutoSize = true;
            OtroGenero.AutoSize = true;

            Masculino.Text = "Masculino";
            Femenino.Text = "Femenino";
            OtroGenero.Text = "Otro Género";

            PromedioNormal.Text = "Menor a 95";
            PromedioExcelencia.Text = "Mayor a 95";


            Masculino.Location = new Point(100,150);
            Femenino.Location = new Point(200, 150);
            OtroGenero.Location = new Point(300, 150);
            PromedioNormal.Location = new Point(250,80);
            PromedioExcelencia.Location = new Point(250,100);



            this.Controls.Add(Masculino);
            this.Controls.Add(Femenino);
            this.Controls.Add(OtroGenero);
            this.Controls.Add(PromedioNormal);
            this.Controls.Add(PromedioExcelencia);

            #endregion

            #region ComboBox 

            ComboBox vistaEstadoCivil = new ComboBox();

            
            vistaEstadoCivil.Height = 40;
            vistaEstadoCivil.Width = 100;

            vistaEstadoCivil.Location = new Point(100,200);

            vistaEstadoCivil.Items.Add("Soltero/a");
            vistaEstadoCivil.Items.Add("Casado/a");
            vistaEstadoCivil.Items.Add("Divorciado/a");

            this.Controls.Add(vistaEstadoCivil);

            #endregion

            #region Botones Normales

            Button botonIngresar = new Button();
            Button botonSalir = new Button();


            botonIngresar.Name = "btnAceptar";
            botonIngresar.Text = "Aceptar";
            botonIngresar.Enabled = true;
            botonIngresar.Location = new Point(320, 300);

            botonSalir.Name = "btnSalir";
            botonSalir.Text = "Salir";
            botonSalir.Enabled = true;
            botonSalir.Location = new Point(400, 300);

            this.Controls.Add(botonIngresar);
            this.Controls.Add(botonSalir);
            #endregion


            #region Eventos

            botonIngresar.Click += BotonIngresar_Click;
            #endregion

            NombrePersona = cajaTextoNombre.Text.ToString();
        }

        private void BotonIngresar_Click(object sender, EventArgs e)
        {
           

            
            this.Hide();
            AccederBeca.ShowDialog();
         

           

        }
    }
}