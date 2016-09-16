<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alunos.aspx.cs" Inherits="AlunoWeb.Alunos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br /><br />
    <asp:TextBox runat="server" ID="txtAluno" placeholder="Digite o nome do aluno" />
    <asp:Button Text="Buscar" ID="cmdBuscar" runat="server" OnClick="cmdBuscar_Click" />

    <br /><br />
    <asp:GridView runat="server" ID="grdAluno" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="NomeAluno" HeaderText="Nome do aluno" />
            <asp:BoundField DataField="EmailAluno" HeaderText="Email do aluno" />
            <asp:TemplateField HeaderText="Atualizar">
                <ItemTemplate>
                    <a href="atualizar.aspx?id=<%#Eval("IdAluno") %>">Atualizar</a>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Deletar">
                <ItemTemplate>
                    <a href="deletar.aspx?id=<%#Eval("IdAluno") %>">Deletar</a>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>
