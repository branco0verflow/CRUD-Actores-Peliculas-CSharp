
using ObligatorioProgramacionII;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObligatorioProgramacion.controller;
using ObligatorioProgramacion.model;


namespace ObligatorioProgramacionII.Vista{
    public partial class PanelListaPeliculas : Form{
        VentanaPrincipal VentanaPrincipal;
        List<Pelicula> Peliculas;

        public PanelListaPeliculas(VentanaPrincipal ventanaPrincipal){
            VentanaPrincipal = ventanaPrincipal;
            InitializeComponent();
            //PARA LISTBOX -> tablaPelicula.SelectedIndexChanged += tablaPelicula_SelectedIndexChanged;
            mostrarPeliculas();
        }

        //MUESTRA TODAS LAS PELICULAS 

        /*PARA LISTBOX ->
         * public void mostrarPeliculas()
        {
            List<Pelicula> peliculas = new PeliculaController().obtenerTodasLasPeliculas();
        tablaPelicula.Items.Clear();
            if (peliculas != null){
                foreach (Pelicula pelicula in peliculas){
                    string infoPelicula = $"{pelicula.Codigo} - {pelicula.Titulo} - {pelicula.Anio} - {pelicula.Genero} - {pelicula.Duracion}";
        tablaPelicula.Items.Add(infoPelicula);
                }
}
        }
        
          public void mostrarPeliculasActor(int idActor){
            List<Pelicula> peliculas = new PeliculaController().obtenerPeliculas(idActor);
            tablaPelicula.Items.Clear();
            if (peliculas != null)
            {
                foreach (Pelicula pelicula in peliculas)
                {
                    string infoaMostrar = $"{pelicula.Codigo} - {pelicula.Titulo} - {pelicula.Anio} - {pelicula.Genero} - {pelicula.Duracion}";
                    tablaPelicula.Items.Add(infoaMostrar);
                }
            }
        }
        
         private void tablaPelicula_SelectedIndexChanged(object sender, EventArgs e){
            if (tablaPelicula != null && tablaPelicula.SelectedIndex >= 0 && VentanaPrincipal != null){
                List<Pelicula> peliculas = new PeliculaController().obtenerTodasLasPeliculas();
                if (peliculas != null && peliculas.Count > 0 && tablaPelicula.SelectedIndex < peliculas.Count){
                    Pelicula peliculaSeleccionada = peliculas[tablaPelicula.SelectedIndex];
                    VentanaPrincipal.setPeliculaSeleccionadaCRUD(peliculaSeleccionada);
                }else{
                    MessageBox.Show("No hay películas disponibles o la lista de películas es null.");
                }
            }
        }
         */

        public void mostrarPeliculas(){
            List<Pelicula> peliculas = new PeliculaController().obtenerTodasLasPeliculas();
            Peliculas = peliculas;
            tablaPelicula.Rows.Clear();
            if (peliculas != null){
                foreach (Pelicula pelicula in peliculas){
                    tablaPelicula.Rows.Add(pelicula.Codigo, pelicula.Titulo, pelicula.Anio, pelicula.Genero, pelicula.Duracion);
                }
            }
        }

        //SELECCIONA PELÍCULA EN LA LISTA
        private void tablaPelicula_CellClick(object sender, DataGridViewCellEventArgs e){
            int numeroFilaSeleccionada = e.RowIndex;
            if (numeroFilaSeleccionada >= 0){
                Pelicula peliculaSeleecionada = Peliculas[numeroFilaSeleccionada];
                VentanaPrincipal.setPeliculaSeleccionadaCRUD(peliculaSeleecionada);
            }
        }

        //REFRESCA LOS CAMPOS DEL FORMULARIO
        public void refrescar(){
            Combo_ListaGenero.Text = "Todos";
            filtroAnioActivo.Checked = false;
            filtroAnio.Value = 2023;
            mostrarPeliculas();
        }

        //ORDENA PELICULAS POR TITULO A-Z 
        private void ordenarAlfabeticamenteTitulo_Click(object sender, EventArgs e){
            List<Pelicula> peliculas = new PeliculaController().peliculasOrdenadasAlfabeticamente();
            Peliculas = peliculas;
            tablaPelicula.Rows.Clear();
            if (peliculas != null){
                foreach (Pelicula pelicula in peliculas){
                    tablaPelicula.Rows.Add(pelicula.Codigo, pelicula.Titulo, pelicula.Anio, pelicula.Genero, pelicula.Duracion);
                }
            }
        }


        #region FILTRADO PELICULAS

        //MUESTRA PELÍCULAS SEGÚN EL ACTOR
        public void mostrarPeliculasActor(int idActor){
            List<Pelicula> peliculas = new PeliculaController().obtenerPeliculas(idActor);
            tablaPelicula.Rows.Clear();
            if (peliculas != null){
                foreach (Pelicula pelicula in peliculas){
                    tablaPelicula.Rows.Add(pelicula.Codigo, pelicula.Titulo, pelicula.Anio, pelicula.Genero, pelicula.Duracion);
                }
            }
        }

        //FILTRA POR AÑO Y GENERO A LA VEZ
        private void filtrarPeliculas(){
            if (filtroAnioActivo.Checked && Combo_ListaGenero.Text != "Todos"){
                cargarTablaPeliculaAnioYGenero();
            }else if (filtroAnioActivo.Checked && Combo_ListaGenero.Text == "Todos"){
                cargarTablaPeliculaAnio();
            }else{
                cargarTablaPeliculaGenero();
            }
        }
        private void cargarTablaPeliculaAnioYGenero(){
            String genero = Combo_ListaGenero.Text;
            int anio = Convert.ToInt32(filtroAnio.Value);
            List<Pelicula> peliculas = new PeliculaController().peliculasFiltradasPorAnioYGenero(anio, genero);
            Peliculas = peliculas;
            tablaPelicula.Rows.Clear();
            if (peliculas != null){
                foreach (Pelicula pelicula in peliculas){
                    tablaPelicula.Rows.Add(pelicula.Codigo, pelicula.Titulo, pelicula.Anio, pelicula.Genero, pelicula.Duracion);
                }
            }
        }

        //FILTRAR POR AÑO
        private void cargarTablaPeliculaAnio(){
            List<Pelicula> peliculas;
            peliculas = new PeliculaController().peliculasFiltradasPorAnio(Convert.ToInt32(filtroAnio.Value));
            Peliculas = peliculas;
            tablaPelicula.Rows.Clear();
            if (peliculas != null){
                foreach (Pelicula pelicula in peliculas){
                    tablaPelicula.Rows.Add(pelicula.Codigo, pelicula.Titulo, pelicula.Anio, pelicula.Genero, pelicula.Duracion);
                }
            }
        }
        private void filtroAnio_ValueChanged(object sender, EventArgs e){
            filtrarPeliculas();
        }
        private void filtroAnioActivo_CheckedChanged(object sender, EventArgs e){
            filtrarPeliculas();
        }

        //FILTRAR POR GÉNERO
        private void cargarTablaPeliculaGenero(){
            if (Combo_ListaGenero.Text == "Todos"){
                mostrarPeliculas();
            }else{
                List<Pelicula> peliculas = new PeliculaController().peliculasFiltradasPorGenero(Combo_ListaGenero.Text);
                Peliculas = peliculas;
                tablaPelicula.Rows.Clear();
                if (peliculas != null){
                    foreach (Pelicula pelicula in peliculas){
                        tablaPelicula.Rows.Add(pelicula.Codigo, pelicula.Titulo, pelicula.Anio, pelicula.Genero, pelicula.Duracion);
                    }
                }
            }
        }
        private void Combo_ListaGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarPeliculas();
        }

        //BUSCA PELICULA POR TITULO
        private void buscadorPorTituloPelicula(){
            if (buscadorTitulo.Text == ""){
                mostrarPeliculas();
            }else{
                List<Pelicula> peliculas = new PeliculaController().buscadorPorTituloPelicula(buscadorTitulo.Text);
                Peliculas = peliculas;
                tablaPelicula.Rows.Clear();
                if (peliculas != null){
                    foreach (Pelicula pelicula in peliculas){
                        tablaPelicula.Rows.Add(pelicula.Codigo, pelicula.Titulo, pelicula.Anio, pelicula.Genero, pelicula.Duracion);
                    }
                }
            }
        }
        private void buscadorTitulo_TextChanged(object sender, EventArgs e){
            buscadorPorTituloPelicula();
        }

        #endregion

    }
}
