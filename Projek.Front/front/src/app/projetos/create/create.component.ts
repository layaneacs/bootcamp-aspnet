import { MatDialog, MatDialogRef } from '@angular/material/dialog';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})
export class CreateComponent implements OnInit {

  public form: FormGroup;

  constructor(
    private fb: FormBuilder, 
    private dialog: MatDialogRef<CreateComponent>) { 

      this.form = fb.group ({
        usuarioId: 1,
        nome: [
          '', 
          Validators.compose([
            Validators.maxLength(20),
            Validators.min(6),
            Validators.required,
          ]),
        ],
        descricao: [
          '',
          Validators.compose([
            Validators.maxLength(200),
            Validators.minLength(6),   
          ])        
        ],
        criadoEm: Date,  
        linguagens: [
          '',
          Validators.compose([
            Validators.maxLength(200),
            Validators.minLength(6),
          ])            
        ],
      })
    }

  ngOnInit(): void {
  }

  close() {
    this.dialog.close();
  }

  submit() {
    this.dialog.close(this.form.value);
  }

}
