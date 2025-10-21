using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatos
{
    public class Lista
    {
        public Contato Head { get; set; }

        public Contato Tail { get; set; }

        public int Contador { get; set; }

        public Lista()
        {
            this.Head = null;
            this.Tail = null;
        }

        public bool Vazia()
        {
            return this.Head == null;
        }

        public void InserirInicio(Contato c)
        {
            if (this.Head == null)
            {
                this.Head = c;
                this.Tail = c;
            }
            else
            {
                c.Proximo = this.Head;
                this.Head = c;
            }
        }

        public void InserirMeio(Contato anterior, Contato proximo, Contato novo)
        {   
            anterior.Proximo = novo;
            novo.Proximo = proximo;         
        }

        public void InserirFinal(Contato c)
        {
            this.Tail.Proximo = c;
            this.Tail = c;
            
        }

        public void Inserir(Contato novo)
        {
            if(Vazia())
            {
                InserirInicio(novo);
            }
            else
            {
                if(String.Compare(novo.Nome, this.Head.Nome, StringComparison.Ordinal) < 0)
                {
                    InserirInicio(novo);
                }
                else if(String.Compare(novo.Nome, this.Tail.Nome, StringComparison.Ordinal) > 0)
                {
                    InserirFinal(novo);
                }
                else
                {
                    Contato proximo = this.Head.Proximo;
                    Contato anterior = Head;

                    while(String.Compare(novo.Nome, proximo.Nome, StringComparison.Ordinal) > 0)
                    {
                        anterior = proximo;
                        proximo = proximo.Proximo;
                    }

                    InserirMeio(anterior, proximo, novo);                }
            }
        }

        public void RemoverInicio()
        {
            
        }
        public void RemoverMeio()
        {

        }

        public void RemoverFinal()
        {

        }

        public void Remover(int opcaoRemocao)
        {
            if (opcaoRemocao == 1)
            {
                RemoverInicio();
            }
            else if (opcaoRemocao == 2)
            {
                RemoverMeio();
            }
            else
            {
                RemoverFinal();
            }
        }

        public int MostrarTamanho()
        {
            return Contador;
        }

        public void ImprimirLista()
        {

        }


    }
}
