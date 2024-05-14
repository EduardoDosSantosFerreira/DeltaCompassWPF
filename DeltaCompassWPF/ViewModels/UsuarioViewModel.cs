﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DeltaCompassWPF.Commands;
using DeltaCompassWPF.Models;
using DeltaCompassWPF.Database;
using MySql.Data.MySqlClient;
using System.Xml.Linq;
using Mysqlx.Crud;

namespace DeltaCompassWPF.ViewModels
{
    internal class UsuarioViewModel
    {
        private Usuario _usuario;
        private const string ConnectionString = "server=localhost;database=Delta_Compass;port=3307;user=root;password=usbw";


        public Usuario Usuario
        {
            get { return _usuario; }
            set 
            { 
                _usuario = value;
                OnPropertyChanged(nameof(Usuario));
            }
        }

        public ICommand SalvarCommand { get; private set; }

        public UsuarioViewModel()
        {
            SalvarCommand = new RelayCommand(Salvar, Verificar);
            Usuario = new Usuario();
        }

        private void Salvar(object parameter)
        {
            try
            {
                using(MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = 
                        "INSERT INTO tb_usuario (nm_cadastro, ds_email, nm_apelido, nr_telefone, ds_bio, dpi_usuario, " +
                        "nm_monitor, nm_mouse, nr_resolucaoY, nr_resolucaoX) " +
                        "VALUES (@Nome, @Email, @Apelido, @Telefone, @Biografia, @DpiMouse, " +
                        "@ModeloMonitor, @ModeloMouse, @ResolucaoY, @ResolucaoX)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", Usuario.Nome);
                        command.Parameters.AddWithValue("@Email", Usuario.Email);
                        command.Parameters.AddWithValue("@Apelido", Usuario.ApelidoPerfil);
                        command.Parameters.AddWithValue("@Telefone", Usuario.Telefone);
                        command.Parameters.AddWithValue("@Biografia", Usuario.Biografia);
                        command.Parameters.AddWithValue("@DpiMouse", Usuario.DpiMouse);
                        command.Parameters.AddWithValue("@ModeloMonitor", Usuario.ModeloMonitor);
                        command.Parameters.AddWithValue("@ModeloMouse", Usuario.ModeloMouse);
                        command.Parameters.AddWithValue("@ResolucaoY", Usuario.ResolucaoY);
                        command.Parameters.AddWithValue("@ResolucaoX", Usuario.ResolucaoX);
                        command.ExecuteNonQuery();
                    }
                }
            } catch (Exception)
            {
                throw;
            }
        }

        private bool Verificar(object parameter)
        {
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propriedade)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propriedade));
        }
    }
}
