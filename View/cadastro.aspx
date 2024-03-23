<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastro.aspx.cs" Inherits="StageUP.View.cadastro" %>

<!DOCTYPE html>
<html lang="pt-br">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>StageUp - Cadastre-se</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <link rel="stylesheet" href="./Assets/css/cadastro.css">
</head>

<body class="container">
    <form runat="server">
        <div class="row">
            <div class="col-6 bg-white rounded-start-4">
                <div class="row g-3 mt-2">
                    <div class="col-md-6">
                        <label for="inputNome" class="form-label">Nome:</label>
                        <asp:TextBox ID="txt_Nome" runat="server" CssClass="form-control border border-danger" Style="--bs-border-opacity: .5;" ViewStateMode="Enabled"></asp:TextBox>
                    </div>
                    <div class="col-md-6">
                        <label for="inputSobrenome" class="form-label">Sobrenome:</label>
                        <asp:TextBox ID="txt_Sobrenome" runat="server" CssClass="form-control border border-danger" Style="--bs-border-opacity: .5;" ViewStateMode="Enabled"></asp:TextBox>
                    </div>
                    <div class="col-md-6">
                        <label for="inputEmail4" class="form-label">Email:</label>
                        <asp:TextBox ID="txt_Email" runat="server" CssClass="form-control border border-danger" Style="--bs-border-opacity: .5;" ViewStateMode="Enabled"></asp:TextBox>
                    </div>
                    <div class="col-md-6">
                        <label for="inputCelular" class="form-label">Celular:</label>
                        <asp:TextBox ID="txt_Celular" runat="server" CssClass="form-control border border-danger" Style="--bs-border-opacity: .5;"></asp:TextBox>
                    </div>
                    <div class="col-md-6">
                        <label for="inputSenha" class="form-label">Senha:</label>
                        <asp:TextBox ID="txt_Senha" runat="server" TextMode="Password" CssClass="form-control border border-danger" Style="--bs-border-opacity: .5;" ViewStateMode="Enabled"></asp:TextBox>
                    </div>
                    <div class="col-md-6">
                        <label for="inputCPF" class="form-label">Confirmar senha:</label>
                        <asp:TextBox ID="txt_Senha2" runat="server" CssClass="form-control border border-danger" Style="--bs-border-opacity: .5;" ViewStateMode="Enabled"></asp:TextBox>
                    </div>
                    <div class="col-12">
                        <label for="inputRuaNumero" class="form-label">Rua</label>
                        <asp:TextBox ID="txt_Rua" runat="server" CssClass="form-control border border-danger" Style="--bs-border-opacity: .5;"></asp:TextBox>
                    </div>
                    <div class="col-12">
                        <label for="inputBairro" class="form-label">Bairro</label>
                        <asp:TextBox ID="txt_Bairro" runat="server" CssClass="form-control border border-danger" Style="--bs-border-opacity: .5;"></asp:TextBox>
                    </div>
                    <div class="col-md-6">
                        <label for="inputCidade" class="form-label">Cidade</label>
                        <asp:TextBox ID="txt_Cidade" runat="server" CssClass="form-control border border-danger" Style="--bs-border-opacity: .5;"></asp:TextBox>
                    </div>
                    <div class="col-md-4">
                        <label for="inputEstado" class="form-label">Estado</label>
                        <asp:DropDownList ID="drop_Estado" runat="server" CssClass="form-select border border-danger" Style="--bs-border-opacity: .5;">
                            <asp:ListItem Selected="True">Selecione seu estado</asp:ListItem>
                            <asp:ListItem Value="AC">AC - Acre</asp:ListItem>
                            <asp:ListItem Value="AL">AL - Alagoas</asp:ListItem>
                            <asp:ListItem Value="AP">AP - Amapá</asp:ListItem>
                            <asp:ListItem Value="AM">AM - Amazonas</asp:ListItem>
                            <asp:ListItem Value="BA">BA - Bahia</asp:ListItem>
                            <asp:ListItem Value="CE">CE - Ceará</asp:ListItem>
                            <asp:ListItem Value="DF">DF - Distrito Federal</asp:ListItem>
                            <asp:ListItem Value="ES">ES - Espírito Santo</asp:ListItem>
                            <asp:ListItem Value="GO">GO - Goiás</asp:ListItem>
                            <asp:ListItem Value="MA">MA - Maranhão</asp:ListItem>
                            <asp:ListItem Value="MT">MT - Mato Grosso</asp:ListItem>
                            <asp:ListItem Value="MS">MS - Mato Grosso do Sul</asp:ListItem>
                            <asp:ListItem Value="MG">MG - Minas Gerais</asp:ListItem>
                            <asp:ListItem Value="PA">PA - Pará</asp:ListItem>
                            <asp:ListItem Value="PB">PB - Paraíba</asp:ListItem>
                            <asp:ListItem Value="PR">PR - Paraná</asp:ListItem>
                            <asp:ListItem Value="PE">PE - Pernambuco</asp:ListItem>
                            <asp:ListItem Value="PI">PI - Piauí</asp:ListItem>
                            <asp:ListItem Value="RJ">RJ - Rio de Janeiro</asp:ListItem>
                            <asp:ListItem Value="RN">RN - Rio Grande do Norte</asp:ListItem>
                            <asp:ListItem Value="RS">RS - Rio Grande do Sul</asp:ListItem>
                            <asp:ListItem Value="RO">RO - Rondônia</asp:ListItem>
                            <asp:ListItem Value="RR">RR - Roraima</asp:ListItem>
                            <asp:ListItem Value="SC">SC - Santa Catarina</asp:ListItem>
                            <asp:ListItem Value="SP">SP - São Paulo</asp:ListItem>
                            <asp:ListItem Value="SE">SE - Sergipe</asp:ListItem>
                            <asp:ListItem Value="TO">TO - Tocantins</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                           <div class="col-md-2">
                        <label for="inputCEP" class="form-label">CEP</label>
                        <asp:TextBox ID="txt_CEP" runat="server" CssClass="form-control border border-danger" Style="--bs-border-opacity: .5;" OnTextChanged="txt_CEP_TextChanged" AutoPostBack="True" TextMode="Number"></asp:TextBox>
                    </div>
                    <div class="col-12 text-center">
                        <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar-se" CssClass="btn btn-danger" OnClick="btnCadastrar_Click" />
                    </div>
                    <div class="col-12 text-center">
                        <p>Já tem uma conta?<a href="./index.aspx" class="text-danger link-login"> Faça o Login!</a></p>
                    </div>
                </div>
            </div>
            <div class="col-6 fundo rounded-end-4">
                <h2 class="text-center mt-5 text-light">Bem-vindo(a) ao Stage<span class="text-danger">Up</span>!</h2>
                <p class="text-center mt-3 fs-5 text-light">Realize seu cadastro utilizando suas informações pessoais:</p>
                <img src="" alt="">
            </div>
        </div>

        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"
            integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz"
            crossorigin="anonymous"></script>
        <script src=""></script>
    </form>
</body>
</html>