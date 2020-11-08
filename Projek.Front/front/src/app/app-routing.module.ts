import { CreateComponent } from './projetos/create/create.component';
import { PainelComponent } from './pages/painel/painel.component';

import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [
  { 
    path: "painel", 
    component: PainelComponent,      
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
