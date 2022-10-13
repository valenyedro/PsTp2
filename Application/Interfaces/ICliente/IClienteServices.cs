﻿using Application.Models;
using Application.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.ICliente
{
    public interface IClienteServices
    {
        Task<ClienteResponse> CreateCliente(ClienteRequest request);
        Task<Cliente> UpdateCliente(Cliente cliente);
        Task<Cliente> DeleteCliente(Cliente cliente);
        Task<List<Cliente>> GetAllClientes();
        Task<Cliente> GetClienteById(int id);
        Task NewCarritoActive(int clienteId);
    }
}
