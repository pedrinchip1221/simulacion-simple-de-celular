using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celular.Modelo
{
    public class telefono
    {
        
        private int Numeroserie;
        private string Marca;
        private int Numero;
        private string Propietario;
        private bool Estado;
        private bool On_off;
        

        public telefono() { }

        public telefono( int Numeroserie, string Marca, int Numero, string Propietario, bool Estado, bool On_off)
        {
            this.Numeroserie = Numeroserie;
            this.Marca = Marca;
            this.Numero = Numero;
            this.Propietario = Propietario;
            this.Estado = Estado;
            this.On_off = On_off;            
        }
        public int getNserie() //get
        {
            return this.Numeroserie;
        }
        public void setNserie(int Numeroserie) //set
        {
            this.Numeroserie = Numeroserie;
        }        
        public string getMarca() {return this.Marca;}
        public void setMarca(string Marca) { this.Marca = Marca; }
        public int getNumero() { return this.Numero;}
        public void setNumero(int Numero) { this.Numero = Numero; }
        public string getPropietario() { return this.Propietario;}
        public void setPropietario(string Propietario) {this.Propietario = Propietario;}
        public bool getEstado() { return this.Estado; }
        public void setEstado(bool Estado) { this.Estado = Estado;}   
        public bool getOn_off() {  return this.On_off; }
        public void setOn_off(bool On_off) {this.On_off = On_off;}
    }
}
