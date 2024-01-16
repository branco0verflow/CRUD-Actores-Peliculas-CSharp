using ObligatorioProgramacion.controller;
using ObligatorioProgramacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObligatorioProgramacion.model;
using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObligatorioProgramacionII.Vista{
    public partial class PanelListaActores : Form{

        VentanaPrincipal VentanaPrincipal;
        List<Actor> Actores;
        public PanelListaActores(VentanaPrincipal ventanaPrincipal){
            InitializeComponent();
            VentanaPrincipal = ventanaPrincipal;
        }

        //MUESTRA TODOS LOS ACTORES
        public void mostrarActores(){
            List<Actor> actores = new ActorController().obtenerTodosLosActores();
            Actores = actores;
            tablaActores.Rows.Clear();
            if (actores != null){
                foreach (Actor actor in actores){
                    tablaActores.Rows.Add(actor.NroActor, actor.Nombre, actor.Apellido, actor.FechaDeNacimiento.ToString("dd-MM-yyyy"), actor.Nacionalidad, actor.Telefono);
                }
            }
        }

        //MUESTRA ACTORES SEGÚN LA PELÍCULA
        public void mostrarActoresPelicula(int codigoPelicula){
            List<Actor> actores = new ActorController().obtenerActores(codigoPelicula);
            Actores = actores;
            tablaActores.Rows.Clear();
            if (actores != null){
                foreach (Actor actor in actores){
                    tablaActores.Rows.Add(actor.NroActor, actor.Nombre, actor.Apellido, actor.FechaDeNacimiento.ToString("dd-MM-yyyy"), actor.Nacionalidad, actor.Telefono);
                }
            }
        }
        private void tablaActores_CellClick(object sender, DataGridViewCellEventArgs e){
            int numeroFilaSeleccionada = e.RowIndex;
            if (numeroFilaSeleccionada >= 0){
                Actor actor = Actores[numeroFilaSeleccionada];
                VentanaPrincipal.setActorSeleccionadoCRUD(actor);
            }
        }
        
        //FILTRA LOS ACTORES POR NACIONALIDAD
        public void cargarTablaActorNacionalidad(){
            if (filtroActorNacionalidad.Text == "Todos"){
                mostrarActores();
            }else{
                List<Actor> actores = new ActorController().obtenerActoresPorNacionalidad(filtroActorNacionalidad.Text);
                Actores = actores;
                tablaActores.Rows.Clear();
                if (actores != null){
                    foreach (Actor actor in actores){
                        tablaActores.Rows.Add(actor.NroActor, actor.Nombre, actor.Apellido, actor.FechaDeNacimiento.ToString("dd-MM-yyyy"), actor.Nacionalidad, actor.Telefono);
                    }
                }
            }  
        }
        private void filtroActorNacionalidad_SelectedIndexChanged(object sender, EventArgs e){
            cargarTablaActorNacionalidad();
        }

        //BUSCA POR NOMBRE DE ACTOR 
        private void buscadorPorNombreActor()
        {
            if (buscadorNombres.Text == ""){
                mostrarActores();
            }else{
                List<Actor> actores = new ActorController().buscadorPorNombreActor(buscadorNombres.Text);
                Actores = actores;
                tablaActores.Rows.Clear();
                if (actores != null){
                    foreach (Actor actor in actores){
                        tablaActores.Rows.Add(actor.NroActor, actor.Nombre, actor.Apellido, actor.FechaDeNacimiento.ToString("dd-MM-yyyy"), actor.Nacionalidad, actor.Telefono);
                    }
                }
            }
        }
        private void buscadorNombres_TextChanged(object sender, EventArgs e)
        {
            buscadorPorNombreActor();
        }
    }
}
