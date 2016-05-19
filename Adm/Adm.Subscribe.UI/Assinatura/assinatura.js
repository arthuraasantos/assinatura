var app = angular.module('assinaturaApp', []);

app.controller('assinaturaCtrl', function($scope, $http) {

    var produtos = [];
    $scope.modalidadesDeAssinatura = ["Mensal", "Semestral", "Anual"];
    $scope.totalAssinatura = 0;
    $scope.assinatura = {
        Modulos : $scope.produtos,
        Modalidade: "Nenhuma",
        Valor : 0.00
    };

    //Métodos
    var carregarProdutos = function() {

        var itens = [
            {
                Nome: "Erp básico",
                Valor: 29.90,
                Descricao: "Software erp básico com controle básico de estoque, produtos e vendas"
            },
            {
                Nome: "Módulo Compras",
                Valor: 29.90,
                Descricao: "Módulo avançado de compras, com compra inteligente e previsão de produtos"
            },
            {
                Nome: "Módulo Boleto",
                Valor: 19.90,
                Descricao: "Boleto registrado"
            },
            {
                Nome: "Módulo Nota Fiscal",
                Valor: 39.90,
                Descricao: "Módulo Fiscal NFSE"
            },
            {
                Nome: "Módulo Logística",
                Valor: 39.90,
                Descricao: "Módulo Logística"
            }
        ];
    
        $scope.produtos = itens;
    };

    var carregarModalidadesDeAssinatura = function() {
        $scope.modalidadesDeAssinatura = [
            {
                Tipo: "Mensal",
                Intervalo: 1
            },
            {
                Tipo: "Semestral",
                Intervalo: 6
            },
            {
                Tipo: "Anual",
                Intervalo: 12
            }
        ];
    };
    var resetarTipoModalidade = function() {
        $('input[name="tipoModalidade"]').attr('checked', false);
        $("input[type='radio'][name='tipoModalidade']").closest('[data-type]').removeClass('active');
    };


    var resetarFormulario = function () {
        resetarTipoModalidade();
        carregarProdutos();
        carregarModalidadesDeAssinatura();
    };

    

    $scope.selecionarModalidade = function () {
        $("input[type='radio'][name='tipoModalidade']").closest('[data-type]').removeClass('active');

        var divSelecionada = $("input[type='radio'][name='tipoModalidade']:checked").closest('[data-type]');
        divSelecionada.addClass('active');
    };


    var adicionarModulo = function (modulo) {
        $scope.assinatura += { name: "ok" };
        //var moduloExistente = angular.forEach($scope.assinatura, function(value, key) {
        //    if (modulo.Nome === value) {
        //        $scope.assinatura += modulo;
        //    }
        //});
    };

    resetarFormulario();


})