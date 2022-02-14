﻿using MediatR;
using SistemaCompra.Domain.Core.Model;
using SistemaCompra.Domain.SolicitacaoCompraAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaCompra.Application.SolicitacaoCompra.Command.RegistrarCompra
{
    public class RegistrarCompraCommand : IRequest<bool>
    {
        public UsuarioSolicitante UsuarioSolicitante { get;  set; }
        public NomeFornecedor NomeFornecedor { get;  set; }
        public IList<Item> Itens { get;  set; }
        public DateTime Data { get;  set; }
        public Money TotalGeral { get;  set; }
        public Situacao Situacao { get;  set; }

    }
}
