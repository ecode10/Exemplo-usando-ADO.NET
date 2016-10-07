<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alunos.aspx.cs" Inherits="AlunoWeb.Alunos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br /><br />

    <asp:GridView runat="server" ID="grdAluno" AutoGenerateColumns="true">
        <Columns>
            <asp:BoundField DataField="NomeAluno" HeaderText="Nome do aluno" />
            <asp:BoundField DataField="EmailAluno" HeaderText="Email do aluno" />
            
        </Columns>
    </asp:GridView>

</asp:Content>
