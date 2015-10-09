var smsModule = new function () { }

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
            if(($($('.s-menu-item-value')[i])).attr("data-action") === act) {
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

smsModule.Init = function() {
    smsModule.Menu.Init();
    smsModule.ControlsInitialization();
    smsModule.Knockout.Mappings.Map();
}

smsModule.ControlsInitialization = function() {
    $("#DoNotSendSmsAddToOrder").bootstrapToggle({ on: 'Да', off: 'Нет' });
    $("#TranslitAddToOrder").bootstrapToggle({ on: 'Да', off: 'Нет' });

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
    
}


smsModule.Knockout = new function () { };

smsModule.Knockout.Mappings = new function () { };

smsModule.Knockout.Mappings.MapChildModel = function(data) {
    ko.mapping.fromJS(data, {}, this);
}

smsModule.Knockout.Mappings.Map = function () {
    var viewModel = ko.mapping.fromJS(smsModule.Models);
    ko.mapping.fromJS(smsModule.Models, viewModel);
    ko.applyBindings(viewModel);
}

 

