﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIBoletim.Domains;

namespace APIBoletim.Interfaces
{
    interface IAluno
    {
        Aluno Cadastrar(Aluno a);
        List<Aluno> LerTodos();
        Aluno BuscarPorId(int id);
        Aluno Alterar(int id, Aluno a);
        void Excluir(int id);
   
    }
}
