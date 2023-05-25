using n1_inmobiliaria.source.mundo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n1_inmobiliaria.sourse.mundo
{
    public class Inmobiliaria
    {
        // Atributos de relación
        private Casa casa1;
        private Casa casa2;
        private Casa casa3;

        // Método inicializador o constructor
        public void inicializar()
        {
            casa1 = new Casa();
            casa1.inicializar();
            casa2 = new Casa();
            casa2.inicializar();
            casa3 = new Casa();
            casa3.inicializar();
        }

        // Método para dar la información de la casa 1
        public Casa darCasa1()
        {
            return casa1;
        }

        // Método para dar la información de la casa 2
        public Casa darCasa2()
        {
            return casa2;
        }

        // Método para dar la información de la casa 3
        public Casa darCasa3()
        {
            return casa3;
        }

        // Método para actualizar la información de la casa 1
        public void actualizarDatosCasa1(int habitantes, int numParqueadero, int numEmpleados, int precio, int tamanio)
        {
            casa1.modificarHabitantes(habitantes);
            casa1.modificarNumeroParqueaderos(numParqueadero);
            casa1.modificarNumeroEmpleados(numEmpleados);
            casa1.modificarPrecio(precio);
            casa1.modificarTamanio(tamanio);
        }

        // Método para actualizar la información de la casa 2
        public void actualizarDatosCasa2(int habitantes, int numParqueadero, int numEmpleados, int precio, int tamanio)
        {
            casa2.modificarHabitantes(habitantes);
            casa2.modificarNumeroParqueaderos(numParqueadero);
            casa2.modificarNumeroEmpleados(numEmpleados);
            casa2.modificarPrecio(precio);
            casa2.modificarTamanio(tamanio);
        }

        // Método para actualizar la información de la casa 3
        public void actualizarDatosCasa3(int habitantes, int numParqueadero, int numEmpleados, int precio, int tamanio)
        {
            casa3.modificarHabitantes(habitantes);
            casa3.modificarNumeroParqueaderos(numParqueadero);
            casa3.modificarNumeroEmpleados(numEmpleados);
            casa3.modificarPrecio(precio);
            casa3.modificarTamanio(tamanio);
        }

        public double calcularCostoAdministrativo()
        {
            double sumaLimpieza = casa1.calcularCostoLimpieza() + casa2.calcularCostoLimpieza() + casa3.calcularCostoLimpieza();
            double porcentajeLimpieza = (sumaLimpieza * 25) / 100;
            double totalSumaSeguridad = casa1.calcularCostoSeguridad() + casa2.calcularCostoSeguridad() + casa3.calcularCostoSeguridad();
            double porcentajeSeguridad = (totalSumaSeguridad * 10) / 100;
            double costoAdministrativoTotal = porcentajeLimpieza + porcentajeSeguridad;
            return costoAdministrativoTotal;
        }

        public double calcularCostoPromedioServicios()
        {
            double totalCostoPromedio = (casa1.calcularCostoServicios() + casa2.calcularCostoServicios() + casa3.calcularCostoServicios()) / 3;
            return totalCostoPromedio;
        }
    }
}
