# Estacionamento - Sistema de Gerenciamento de Estacionamento

Este é um projeto de exercício em C# para um sistema simples de gerenciamento de estacionamento, desenvolvido como parte de um curso da DIO (Digital Innovation One). O aplicativo permite cadastrar veículos, removê-los com cálculo de tarifa e listar os veículos estacionados.

# Funcionalidades
Cadastrar Veículo: Adiciona um veículo ao estacionamento informando a placa.
Remover Veículo: Remove um veículo, calcula o valor total baseado no preço inicial e preço por hora, e exibe o custo.
Listar Veículos: Exibe todos os veículos atualmente estacionados.
Menu Interativo: Interface de console com opções para navegar entre as funcionalidades.

Tecnologias Utilizadas
Linguagem: C#
Framework: .NET 10.0
Tipo de Projeto: Console Application

# Como Executar

- Certifique-se de ter o .NET SDK 10.0 instalado.
- Clone ou baixe o projeto.
- Navegue até o diretório do projeto no terminal.
- Execute o comando para restaurar dependências e compilar:
- Execute o aplicativo:

O menu interativo será exibido no console. Siga as instruções para interagir com o sistema.

Estrutura do Projeto
Program.cs: Ponto de entrada principal com o loop do menu.
Estacionamento.cs: Classe que contém a lógica de gerenciamento dos veículos e cálculos de tarifa.
