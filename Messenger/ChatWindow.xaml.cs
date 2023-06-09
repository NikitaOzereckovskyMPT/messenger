﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Messenger
{
    /// <summary>
    /// Логика взаимодействия для ChatWindow.xaml
    /// </summary>
    public partial class ChatWindow : Window
    {
        public ChatWindow()
        {
            InitializeComponent();
        }
        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Отправить сообщение на сервер
            string message = MessageTextBox.Text;
            // Очистите текстовое поле после отправки сообщения
            MessageTextBox.Clear();

            // Добавьте отправленное сообщение в ListBox
            ChatListBox.Items.Add(new Message { Sender = "Me", Text = message });
        }
        public class Message
        {
            public string Sender { get; set; }
            public string Text { get; set; }

            public override string ToString()
            {
                return $"{Sender}: {Text}";
            }

        }
    }
}
