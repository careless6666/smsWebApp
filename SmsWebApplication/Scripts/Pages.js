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
    smsModule.ControlsInitialization.AddToOrder();
    smsModule.Knockout.Mappings.Map();
}

smsModule.ControlsInitialization = new function() {
    return {
        AddToOrder: function () {
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

            $("#UnitAddToOrder").select2({
                placeholder: "Выберите подразделение",
                allowClear: true
            });

            $("#NetAddToOrder").select2({
                placeholder: "Выберите подразделение",
                allowClear: true
            });

            $("#ClientAddToOrder").select2({
                placeholder: "Выберите сеть",
                allowClear: true
            });
            
        }
    }
};



    


smsModule.Knockout = new function () { };

smsModule.Knockout.Mappings = new function () { };

smsModule.Knockout.Mappings.MapChildModel = function(data) {
    ko.mapping.fromJS(data, {}, this);
}

smsModule.Knockout.Mappings.Map = function () {

    var self = this;
    //add hadlers
    smsModule.Models.AddToOrderViewModel.ChangeUnit = function () {
        $.ajax({
            url: getNetsUrl,
            data: {
                unitId: $('#UnitAddToOrder').select2('data').id
            },
            success: function (data) {
                var jsonData = JSON.parse(ko.toJSON(self.viewModel));
                jsonData.AddToOrderViewModel.Networks = data;
                ko.mapping.fromJS(jsonData, self.viewModel);
                //reset selection 
                $('#NetAddToOrder').select2('data', null);
                //select first element
                if ($('#NetAddToOrder option:eq(0)').length > 0)
                    $('#NetAddToOrder').select2().select2('val', $('#NetAddToOrder option:eq(0)').val());

            }
        });
    }

    smsModule.Models.AddToOrderViewModel.ChangeNet = function() {
        $.ajax({
            url: getClientsUrl,
            data: {
                netId: $('#NetAddToOrder').select2('data').id,
                unitId: $('#UnitAddToOrder').select2('data').id
                
            },
            success: function(data) {
                        var jsonData = JSON.parse(ko.toJSON(self.viewModel));
                        jsonData.AddToOrderViewModel.Clients = data;
                        ko.mapping.fromJS(jsonData, self.viewModel);
                        //reset selection 
                        $('#ClientAddToOrder').select2('data', null);
                        //select first element
                        if ($('#ClientAddToOrder option:eq(0)').length > 0)
                            $('#ClientAddToOrder').select2().select2('val', $('#ClientAddToOrder option:eq(0)').val());

            }
        });
    };

    //bind modal
    self.viewModel = ko.mapping.fromJS(smsModule.Models);
    ko.mapping.fromJS(smsModule.Models, self.viewModel);
    ko.applyBindings(self.viewModel);


    
}


