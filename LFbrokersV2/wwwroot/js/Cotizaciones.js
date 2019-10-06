// Especialidades
function changeText2() {
    var list = document.getElementById('demo');
    var especialidadId = document.getElementById('firstname').value;
    var especialidadText = document.getElementById('firstname').options[document.getElementById('firstname').selectedIndex].text;
    var entry = document.createElement('li');
    var especialidadesValues = document.getElementById('Especialidades').value;
    let limit = (especialidadesValues.split(",").length >= 5) ? true : false;
    if (!especialidadesValues.includes(especialidadId) && !limit) {
        especialidadesValues = (especialidadesValues != "") ? especialidadesValues + ',' + especialidadId : especialidadId;
        document.getElementById('Especialidades').value = especialidadesValues;

        entry.appendChild(document.createTextNode(especialidadText));
        entry.setAttribute('id', especialidadId);
        entry.setAttribute('data-name', especialidadText); //added a data-name attribute for easier access to name
        entry.setAttribute('value', especialidadId); //added a data-name attribute for easier access to name


        var removeButton = document.createElement('button');
        removeButton.appendChild(document.createTextNode("eliminar"));
        removeButton.setAttribute('onClick', 'removeName("' + especialidadId + '")');
        entry.appendChild(removeButton);
        //lastid+=1;
        list.appendChild(entry);
    }
}

function removeName(itemid) {
    var list = document.getElementById('demo');

    var esp = document.getElementById('Especialidades').value;

    var lastId = (esp.length < esp.indexOf(itemid) + 2) ? true : false;
    let index = esp.indexOf(itemid);
    if (lastId) {
        esp = esp.replace(esp.substring(index - 1, index + 1), "");
    }
    else {
        esp = esp.replace(esp.substring(index, index + 2), "");
    }

    document.getElementById('Especialidades').value = esp;

    var item = document.getElementById(itemid);

    list.removeChild(item);
}

// Validations 
$(document).ready(function () {
    $('#CotizarForm').submit(function (e) {
        e.preventDefault();
        $(".error").remove();

        // Numero Documento
        var tipoDocumento = $('#TipoDocumento').val();
        var nroDocumento = $('#NroDocumento').val();
        var pasaporteError = '<span class="error">El formato tiene que ser 3 letras más 6 números. (ej. AAF487695). O el formato, debe ser igual al numero de documento mas una letra. (ej. 34251170N),</span>';

        if (tipoDocumento == 'Pasaporte') {
            // Valid: 34251170N
            let lastChar = nroDocumento[nroDocumento.length - 1];
            let pasaporte = nroDocumento.substring(0, nroDocumento.length - 1);
            let invalidPasaporte = false;
            if ((typeof lastChar === 'string') && (pasaporte != "" && !isNaN(pasaporte) || parseInt(pasaporte) < 99999999)) {
                // Valid
            }
            else {
                // Valid: AAF487695
                for (let i = 0; i < nroDocumento.length; i++) {
                    if (i == 3) break;
                    if (!isNaN(nroDocumento.charAt(i))) {
                        invalidPasaporte = true;
                    }
                }
                let pasaporteNumbers = nroDocumento.substring(3, nroDocumento.length);
                if (pasaporteNumbers == "" || isNaN(pasaporteNumbers) || parseInt(pasaporteNumbers) < 99999) {
                    invalidPasaporte = true;
                }
            }
            if (invalidPasaporte) {
                $('#NroDocumento').after(pasaporteError);
            }
        }
        else {
            if (isNaN(nroDocumento) || parseInt(nroDocumento) > 99999999) {
                $('#NroDocumento').after('<span class="error">Solo se aceptan hasta 8 caracteres numéricos.</span>');
            }
        }

        // Direccion
        var piso = $('#Piso').val();
        var departamento = $('#Departamento').val();
        if (departamento != "") {
            if (piso == "" || isNaN(piso) || parseInt(piso) > 99) {
                $('#Piso').after('<span class="error">Solo acepta hasta 2 caracteres numéricos.</span>');
            }
        }
        if (piso != "") {
            if (departamento == "" || !isNaN(departamento) || departamento.length > 1) {
                $('#Departamento').after('<span class="error">Solo se acepta 1 letra.</span>');
            }
        }

        // Telefono
        var telefono = $('#Telefono').val();
        var celular = $('#Celular').val();
        if (telefono == "" && celular == "") {
            $('#Telefono').after('<span class="error">Telefono o Celular deben estar completos.</span>');
            $('#Celular').after('<span class="error">Telefono o Celular deben estar completos.</span>');
        }

        // Fecha Nacimiento
        var fechaNacimiento = $('#FechaNacimiento').val();
        function underAgeValidate(birthday) {
            var optimizedBirthday = birthday.replace(/-/g, "/");
            var myBirthday = new Date(optimizedBirthday);
            var currentDate = new Date().toJSON().slice(0, 10) + ' 01:00:00';
            var myAge = ~~((Date.now(currentDate) - myBirthday) / (31557600000));
            return (myAge < 18) ? false : true;
        }
        if (!underAgeValidate(fechaNacimiento)) {
            $('#FechaNacimiento').after('<span class="error">Tiene que ser mayor de 18 años.</span>');
        }

        // Submit form if there are no errors
        if ($(".error").length == 0 && $("#CotizarForm").valid()) {
            $(this).unbind('submit').submit();
        }
    });

});