using System;
using System.Collections.Generic;
using Proyecto.Entidades;
using ProyectoDB;

namespace ProyectoConsola
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////creacion de Empleados
            //Empleado Jaime = new Empleado() { cod_Empleado = "00001", nom_Empleado = "Jaime", direc_Empleado = "Checa", cod_Dis ="001", Cargo="administrador", Edad="20", Telefono=2247857, Celular="0987478547", Ingreso= new DateTime(2022,01,18)};
            ////creacion de usuarios
            //Usuario admin = new Usuario() { activo = "si", cod_Emple = "" };


            //Creacion de Distritos
            Distrito Quito = new Distrito() { cod_Distrito = 1, nom_Distrito="Quito" };
            Distrito Montufar = new Distrito() { cod_Distrito = 2, nom_Distrito = "Montufar" };
            Distrito Esmeraldas = new Distrito() { cod_Distrito = 3, nom_Distrito = "Esmeraldas" };
            Distrito Quininde = new Distrito() { cod_Distrito = 4, nom_Distrito = "Quininde" };
            Distrito Ibarra= new Distrito() { cod_Distrito = 5, nom_Distrito = "Ibarra" };
            Distrito Pimampiro = new Distrito() { cod_Distrito = 6, nom_Distrito = "Pimampiro" };
            Distrito Cotacachi = new Distrito() { cod_Distrito = 7, nom_Distrito = "Cotacachi" };
            Distrito Cayambe = new Distrito() { cod_Distrito = 8, nom_Distrito = "Cayambe" };
            Distrito Mejia = new Distrito() { cod_Distrito = 9, nom_Distrito = "Mejia" };
            Distrito Sigchos = new Distrito() { cod_Distrito = 10, nom_Distrito = "Sigchos" };
            Distrito Pangua = new Distrito() { cod_Distrito = 11, nom_Distrito = "Pangua" };
            Distrito Pujili = new Distrito() { cod_Distrito = 12, nom_Distrito = "Pujili" };
            Distrito Baños = new Distrito() { cod_Distrito = 13, nom_Distrito = "Baños" };

            //creacion de lista de distritos
            List<Distrito> listaDistrito = new List<Distrito> { Quito, Montufar, Esmeraldas, Quininde, Ibarra, Pimampiro, Cotacachi, Cayambe, Mejia, Sigchos, Pangua, Pujili, Baños };

            Conexion conex = new Conexion();
            conex.Distritos.AddRange(listaDistrito);
            conex.SaveChanges();


        }
    }
}
