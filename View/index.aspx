<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="StageUP.View.WebForm1" %>

<!DOCTYPE html>
<html lang="pt-BR" xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>StageUp</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
    <link rel="stylesheet" href="./Assets/css/login.css" />
</head>

<body class="container">
    <form id="form1" runat="server">
        <div class="row">
            <div class="col-6 fundo rounded-start-4">
                <h1 class="text-center text-light LOGO">Stage<span class="text-danger">Up</span></h1>
                <img src="" class="text-light text-center" alt="Grupo de pessoas interagindo e trocando conhecimento" />
            </div>
            <div class="col-6 bg-white rounded-end-4">
                <h2 class="text-center mt-5">Bem-vindo(a) ao Stage<span class="text-danger">Up</span>!</h2>
                <p class="text-center mt-3 fs-5">Realize Login utilizando seus dados de acesso.</p>
                <div action="" class="my-5">
                    <div class="form-floating mb-3">
                        <asp:TextBox ID="txt_InputEmail" runat="server" CssClass="form-control border border-danger" style="--bs-border-opacity: .5;"
                            placeholder="Email"></asp:TextBox>
                        <label for="InputEmail">Email</label>
                    </div>
                    <div class="form-floating">
                        <asp:TextBox ID="txt_InputSenha" runat="server" TextMode="Password" CssClass="form-control border border-danger"
                            style="--bs-border-opacity: .5;" placeholder="Senha"></asp:TextBox>
                        <label for="InputSenha">Senha</label>
                    </div>
                    <div class="col-auto mt-3 d-flex justify-content-between">
                        <asp:Button ID="btnLogar" runat="server" Text="Logar-se" CssClass="btn btn-danger mb-3" OnClick="btnLogar_Click" />
                        <p class="sem-conta">Não tem uma conta?<a href="./cadastro.aspx" class="text-danger link-cadastro"> Cadastre-se!</a></p>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>

</html>
