using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios02_i_h.Models.Cursos
{
    public class CursoDesign : ICurso
    {
        public Instrutor Instrutor { get; set; }
        public string Titulo { get; set; }

        public CursoDesign(string titulo, Instrutor instrutor)
        {
            Titulo = titulo;
            Instrutor = instrutor;
        }

        public void ValidarConteudo()
        {
            Console.WriteLine($"Validando conteúdo do curso de design: {Titulo}");
        }

        public void PublicarCurso()
        {
            Console.WriteLine($"Curso publicado com sucesso: {Titulo} - Instrutor: {Instrutor.Nome} ({Instrutor.Especialidade})");
        }
    }
}