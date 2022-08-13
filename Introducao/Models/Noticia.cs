using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Introducao.Models
{
    public class Noticia
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Categoria { get; set; }
        public string Conteudo { get; set; }
        public DateTime Data { get; set; }

        public IEnumerable<Noticia> TodasAsNoticias()
        {
            var retorno = new Collection<Noticia>
                {
                    new Noticia
                        {
                            Id = 1,
                            Categoria = "Esportes",
                            Titulo = "Felipe Massa ganha F1",
                            Conteudo = "Numa tarde de chuva Felipe Massa ganha F1 no Brasil...",
                            Data = new DateTime(2017,3,1)
                        },
                    new Noticia
                        {
                            Id = 2,
                            Categoria = "Política",
                            Titulo = "Presidente assina convênios",
                            Conteudo = "Durante reunião o presidente Ismael Freitas assinou os convênios...",
                            Data = new DateTime(2017,3,1)
                        },
                    new Noticia
                        {
                            Id = 3,
                            Categoria = "Política",
                            Titulo = "Vereador é eleito pela 4ª vez",
                            Conteudo = "Vereador Fabio Pratt é eleito pela quarta vez...",
                            Data = new DateTime(2017,3,1)
                        },
                    new Noticia
                        {
                            Id = 4,
                            Categoria = "Esportes",
                            Titulo = "O tão sonhado titulo chegou",
                            Conteudo = "Em um jogo que levou os torcedores ao delirio...",
                            Data = new DateTime(2017,3,1)
                        },
                    new Noticia
                        {
                            Id = 5,
                            Categoria = "Humor",
                            Titulo = "O Comediante Anderson Renato fará shou hoje",
                            Conteudo = "O comediante mais engraçados dos comentários do Youtube fará show...",
                            Data = new DateTime(2017,3,1)
                        },
                    new Noticia
                        {
                            Id = 6,
                            Categoria = "Policial",
                            Titulo = "Tenente coronel Lucas Farias Santos assume o controle",
                            Conteudo = "Durante a retomada do morro o tenente coronel disse...",
                            Data = new DateTime(2017,3,1)
                        },
                    new Noticia
                        {
                            Id = 7,
                            Categoria = "Esportes",
                            Titulo = "Atacante do Barcelona faz 4 gols",
                            Conteudo = "O atacante Lucas Farias Santos Messi, fez 4 gols e decidiu o titulo...",
                            Data = new DateTime(2017,3,1)
                        }
                };
            return retorno;
        }

        public Noticia BuscarPorId(int id)
        {
            return TodasAsNoticias().FirstOrDefault(x => x.Id.Equals(id));
        }

        public IEnumerable<Noticia> BuscarPorCategoria(string categoria)
        {
            return TodasAsNoticias().Where(x => x.Categoria.ToLower().Equals(categoria.ToLower()));
        }

        public Noticia BuscarPorIdTituloECategoria(int id, string titulo, string categoria)
        {
            return TodasAsNoticias().FirstOrDefault(x => x.Id.Equals(id) && x.Titulo.Equals(titulo) && x.Categoria.Equals(categoria));
        }
    }
}