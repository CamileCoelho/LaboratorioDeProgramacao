﻿using System.Data.SqlClient;
using LaboratorioDeProgramacao.Dominio.ModuloDisciplina;
using LaboratorioDeProgramacao.Infra.Dados.Sql.Compartilhado;

namespace LaboratorioDeProgramacao.Infra.Dados.Sql.ModuloDisciplina
{
    public class MapeadorDisciplina : MapeadorBase<Disciplina>
    {
        public override void ConfigurarParametros(SqlCommand comando, Disciplina registro)
        {
            comando.Parameters.AddWithValue("@NOME", registro.nome);
            comando.Parameters.AddWithValue("@ID", registro.id);
        }

        public override Disciplina ConverterRegistro(SqlDataReader leitorRegistros)
        {
            int id = Convert.ToInt32(leitorRegistros["DISCIPLINA_ID"]);
            string nome = Convert.ToString(leitorRegistros["DISCIPLINA_NOME"]);

            return new Disciplina(id, nome);
        }
    }
}

