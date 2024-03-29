﻿using A4S.Core.Utils;
using A4S.ERP.Domain.Body;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using A4S.ERP.Infra.Data;
using System.Security.Cryptography;

namespace A4S.ERP.Infra.Repository
{
    public class UsuarioRepository : UserRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(UserDbContext context) : base(context) { }

        public Usuario CriarUsuario(CriarUsuarioRequestBody usuario)
        {
            Hash hash = new Hash(SHA512.Create());

            Usuario usuarioModel = usuario.ToModel();
            usuarioModel.Senha = hash.CriptografarSenha(usuarioModel.Senha, usuarioModel.Guid.ToInt32());

            var retorno = Set.Add(usuarioModel);

            context.SaveChanges();

            return retorno.Entity;
        }

        public string RetornarConnectionString()
        {
            return "server=107.161.183.80;port=3306;userid=colaquen_fernando;password=769619Pp**;database=colaquen_banco_teste;";
        }
    }
}
