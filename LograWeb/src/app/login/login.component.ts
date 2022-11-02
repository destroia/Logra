import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { PruebaService } from '../prueba.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  formularioLogin: FormGroup;
  constructor(private fb: FormBuilder,private prueba: PruebaService) { }

  ngOnInit(): void {
    this.InitFormulario();
  }

  InitFormulario() {
    this.formularioLogin = this.fb.group(
      {
        usuario: ["", Validators.required],
        contrasena: ["sssaa", Validators.required]
      });
  }

  IniciarSesion() {
    
    console.log(this.formularioLogin.value)
    this.prueba.getPueba().subscribe(x => { this.confirmacion(x) }, error => console.log(error));

  }
  confirmacion(x: boolean) {
    console.log(x);
    }

}
