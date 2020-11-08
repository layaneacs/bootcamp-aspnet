import { Projeto } from './../../model/Projeto';
import { CreateComponent } from './../../projetos/create/create.component';
import { Usuario } from './../../model/Usuario';
import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-painel',
  templateUrl: './painel.component.html',
  styleUrls: ['./painel.component.css']
})
export class PainelComponent implements OnInit {

  public projetos: any[] = [];
  cont: number = 0;

  projeto: Projeto;
  usuario: Usuario;

  constructor(public dialog: MatDialog, private http: HttpClient) { 
    
  }

  ngOnInit(): void {
    this.getUser();
  }  

  getUser(){
    this.http
      .get(`${environment.apiUrl}/api/usuarios/1`)
      .subscribe(
        (data:any) => {
          this.usuario = data; 
          this.projetos = data.projetos;
          this.cont = this.projetos.length;        
          console.log(data);
        },
        (error) => {
          console.log(error)
        }
      )

  };

  openDialog(): void {
    const dialogRef = this.dialog.open(CreateComponent, {
      width: '300px',
      data: null,
    });

    dialogRef.afterClosed().subscribe((resultado) => {
      this.addProjeto(resultado);
    })
  }

  addProjeto(projeto){
    this.http
    .post(`${environment.apiUrl}/api/projetos`, projeto )
    .subscribe(
      (data: any) => {
        this.projetos.push(projeto)
      },
      (error) => {
        console.log(error)
      }
    )
  }

  

}
