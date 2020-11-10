import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { PersonaRegisterComponent } from './Gestion/persona-register/persona-register.component';
import { PersonaConsultaComponent } from './Gestion/persona-consulta/persona-consulta.component';
import { RestauranteRegisterComponent } from './Gestion/restaurante-register/restaurante-register.component';
import { RestauranteConsultaComponent } from './Gestion/restaurante-consulta/restaurante-consulta.component';
import { ListaChequeoRegisterComponent } from './Gestion/lista-chequeo-register/lista-chequeo-register.component';
import { ListaChequeoConsultaComponent } from './Gestion/lista-chequeo-consulta/lista-chequeo-consulta.component';

const routes:Routes = [
  
  {
    path:'personaRegister',
    component:PersonaRegisterComponent
  },
  {
    path:'personaConsulta',
    component:PersonaConsultaComponent
  },
  {
    path:'restauranteRegister',
    component:RestauranteRegisterComponent
  },
  {
    path:'restauranteConsulta',
    component:RestauranteConsultaComponent
  },
  {
    path:'listaChequeoRegister',
    component:ListaChequeoRegisterComponent
  },
  {
    path:'listaChequeoConsulta',
    component:ListaChequeoConsultaComponent
  }
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ]
})
export class AppRoutingModule { }
