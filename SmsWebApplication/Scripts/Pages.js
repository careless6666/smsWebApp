﻿var smsModule = new function () { }

smsModule.Menu = new function () { }

smsModule.Models = new function () { }

smsModule.Models.MapAddToOrder = null;

smsModule.Menu.Init = function () {
    function hideAllItems() {
        $('.s-menu-item-value').hide();
        $('#main-page').hide();
        $('.stub-img').hide();
    }

    function showSelected(element) {
        hideAllItems();
        var act = $(element).attr("data-action");

        for (var i = 0; i < $('.s-menu-item-value').length; i++) {
            if (($($('.s-menu-item-value')[i])).attr("data-action") === act) {
                $($('.s-menu-item-value')[i]).show();
                return;
            }
        }
        hideAllItems();
        $('#main-page').show();
        $('.stub-img').show();
    }

    $('.s-menu').click(function () {
        showSelected(this);
    });
}

smsModule.Variables = new function () { };
smsModule.Variables.ItemClick = function (container, event) {
    container(container() + '<%' + $(event.target).text() + '%>');
};


smsModule.Init = function () {
    smsModule.Menu.Init();
    smsModule.ControlsInitialization.AddToOrder();
    smsModule.Knockout.Mappings.Map();
}

smsModule.ControlsInitialization = new function () {
    return {
        AddToOrder: function () {
            $("#DoNotSendSmsAddToOrder").bootstrapToggle({ on: 'Да', off: 'Нет' });
            $("#TranslitAddToOrder").bootstrapToggle({ on: 'Да', off: 'Нет' });
            $("#TranslitAddToOrder").change(function() {
                $("#TranslitAddToOrder").click();
            });

            //TranslitAddToOrder

            $('.form_date').datetimepicker({
                language: 'ru',
                weekStart: 1,
                todayBtn: 1,
                autoclose: 1,
                todayHighlight: 1,
                startView: 2,
                minView: 2,
                forceParse: 0,
                format: 'dd.mm.yyyy'
            });

            $('.form_time').datetimepicker({
                language: 'fr',
                weekStart: 1,
                todayBtn: 1,
                autoclose: 1,
                todayHighlight: 1,
                startView: 1,
                minView: 0,
                maxView: 1,
                forceParse: 0
            });

            $("#SelectedUnitAddToOrder").select2({
                placeholder: "Все",
                allowClear: true
            });

            $("#SelectedNetworkAddToOrder").select2({
                placeholder: "Все",
                allowClear: true
            });

            $("#SelectedClientAddToOrder").select2({
                placeholder: "Все",
                allowClear: true
            });

            $("#SelectedWorkTypesAddToOrder").select2({
                placeholder: "Вcе",
                allowClear: true
            });

            $("#SelectedDepartmentAddToOrder").select2({
                placeholder: "Вcе",
                allowClear: true
            });

        }
    }
};






smsModule.Knockout = new function () { };

smsModule.Knockout.Mappings = new function () { };

smsModule.Knockout.Mappings.MapChildModel = function (data) {
    ko.mapping.fromJS(data, {}, this);
}

smsModule.Knockout.Mappings.Map = function () {

    function rebindSelectList(element, list) {
        var $el = element;
        $el.empty(); // remove old options
        $.each(list, function (value, key) {
            $el.append($("<option></option>")
               .attr("value", key.Id).text(key.Name));
        });
    }

    function getSelect2Ids(element) {
        var arr = $(element).select2('data');
        var res = [];
        $.each(arr, function (index, value) {
            res.push(value.id);
        });
        return res;
    }

    var self = this;
    //add hadlers
    smsModule.Models.AddToOrderVM = new function AddToOrderVM() { };
    smsModule.Models.AddToOrderVM.AddToOrderVM = new function () { };
    var vm = smsModule.Models.AddToOrderVM.AddToOrderVM;
    vm.ChangeUnit = function () {
        $.ajax({
            url: getNetsUrl,
            data: {
                unitId: JSON.stringify(getSelect2Ids($('#SelectedUnitAddToOrder')))
            },
            success: function (data) {
                //var jsonData = JSON.parse(ko.toJSON(self.viewModel));
                //jsonData.AddToOrderViewModel.Networks = data;
                //ko.mapping.fromJS(jsonData, self.viewModel);
                rebindSelectList($('#SelectedNetworkAddToOrder'), data);
                //reset selection 
                $('#SelectedNetworkAddToOrder').select2('data', null);
                //select first element
                //if ($('#SelectedNetworkAddToOrder option:eq(0)').length > 0) {
                //  $('#SelectedNetworkAddToOrder').select2().select2('val', $('#SelectedNetworkAddToOrder option:eq(0)').val());
                // }
                vm.ChangeNet();
            }
        });
    }

    vm.ChangeNet = function () {
        $.ajax({
            url: getClientsUrl,
            data: {
                netId: JSON.stringify(getSelect2Ids($('#SelectedNetworkAddToOrder'))),
                unitId: JSON.stringify(getSelect2Ids($('#SelectedUnitAddToOrder')))

            },
            success: function (data) {
                //var jsonData = JSON.parse(ko.toJSON(self.viewModel));
                // jsonData.AddToOrderViewModel.Clients = data;
                //ko.mapping.fromJS(jsonData, self.viewModel);
                rebindSelectList($('#SelectedClientAddToOrder'), data);
                //reset selection 
                $('#SelectedClientAddToOrder').select2('data', null);
                //select first element
                //if ($('#SelectedClientAddToOrder option:eq(0)').length > 0)
                // $('#SelectedClientAddToOrder').select2().select2('val', $('#SelectedClientAddToOrder option:eq(0)').val());
                vm.ChangeWorkType();
                vm.UpdateDeparments();
            }
        });
    };

    vm.ChangeWorkType = function () {
        $.ajax({
            url: getWorkTypesUrl,
            data: {
                netId: JSON.stringify(getSelect2Ids($('#SelectedNetworkAddToOrder'))),
                unitId: JSON.stringify(getSelect2Ids($('#SelectedUnitAddToOrder'))),
                clientId: JSON.stringify(getSelect2Ids($('#SelectedClientAddToOrder')))

            },
            success: function (data) {
                rebindSelectList($('#SelectedWorkTypesAddToOrder'), data);
                //reset selection 
                $('#SelectedWorkTypesAddToOrder').select2('data', null);
                //select first element
                //if ($('#SelectedClientAddToOrder option:eq(0)').length > 0)
                //    $('#SelectedClientAddToOrder').select2().select2('val', $('#SelectedClientAddToOrder option:eq(0)').val());

            }
        });
        vm.UpdateDeparments();
    };

    vm.UpdateDeparments = function () {
        $.ajax({
            url: getDepartmentsUrl,
            data: {
                clientId: JSON.stringify(getSelect2Ids($('#SelectedClientAddToOrder')))

            },
            success: function (data) {
                rebindSelectList($('#SelectedDepartmentAddToOrder'), data);
                //reset selection 
                $('#SelectedDepartmentAddToOrder').select2('data', null);
                //select first element
                //if ($('#SelectedClientAddToOrder option:eq(0)').length > 0)
                //    $('#SelectedClientAddToOrder').select2().select2('val', $('#SelectedClientAddToOrder option:eq(0)').val());

            }
        });
    };

    vm.ItemClick = smsModule.Variables.ItemClick;

    vm.TranslitText = function (data) {
        var varsArr = [{ id: "<%Data nachala%>", value: "<%Дата начала%>" }, {id: "<%Vremya nachala%>", value:"<%Время начала%>" },
        { id:"<%Data okonchaniya%>", value: "<%Дата окончания%>"}, { id:"<%Vremya okonchaniya%>", value: "<%Время окончания%>"},
        { id:"<%Klient%>", value: "<%Клиент%>" }, { id:"<%Tip raboty'%>", value: "<%Тип работы%>" }, { id:"<%Otdel%>", value: "<%Отдел%>" }, { id:"<%Adres%>", value: "<%Адрес%>" }];
        
        var message = data.AddToOrderVM.Message();
        var enableTranslite = !data.AddToOrderVM.EnableTranslite();
        data.AddToOrderVM.EnableTranslite(enableTranslite);
        var transResult = smsModule.translate(message, !enableTranslite);

        for (var i = 0; i < varsArr.length; i++) 
            transResult = transResult.replace(varsArr[i].id, varsArr[i].value);
        
        data.AddToOrderVM.Message(transResult);
    }

    //bind modal
    var jm = smsModule.Models.AddToOrderViewModel;
    vm.TimeStart = jm.TimeStart;
    vm.TimeEnd = jm.TimeEnd;
    vm.DateStart = jm.DateStart;
    vm.DateEnd = jm.DateEnd;
    vm.Message = jm.Message;
    vm.EnableTranslite = jm.EnableTranslite;


    self.viewModel = ko.mapping.fromJS(smsModule.Models.AddToOrderVM);
    ko.mapping.fromJS(smsModule.Models.AddToOrderVM, self.viewModel);
    ko.applyBindings(self.viewModel);



}


smsModule.translate = function (text, engToRus) {
    var rus = "щ   ш  ч  ц  ю  я  ё  ж  ъ  ы  э  а б в г д е з и й к л м н о п р с т у ф х ь".split(/ +/g),
    eng = "shh sh ch cz yu ya yo zh `` y' e` a b v g d e z i j k l m n o p r s t u f x `".split(/ +/g);
    var x;

    for (x = 0; x < rus.length; x++) {
        text = text.split(engToRus ? eng[x] : rus[x]).join(engToRus ? rus[x] : eng[x]);
        text = text.split(engToRus ? eng[x].toUpperCase() : rus[x].toUpperCase()).join(engToRus ? rus[x].toUpperCase() : eng[x].toUpperCase());
    }
    return text;
}

