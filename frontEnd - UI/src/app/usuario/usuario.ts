import { Component } from '@angular/core';
import { UsuarioService } from '../services/usuario.service';
import {MatTableDataSource, MatTableModule} from '@angular/material/table';
import { Observable } from 'rxjs';
import { UsuarioInterface } from '../intefaces/usuario.interface';
import { AsyncPipe } from '@angular/common';

@Component({
    selector: 'app-usuario',
    imports: [MatTableModule, AsyncPipe],
    templateUrl: './usuario.html',
    styleUrl: './usuario.css'
})
export class Usuario {

//dataSource = new MatTableDataSource<UsuarioService>();

    usuarios$ = new Observable<UsuarioInterface[]>();

    constructor(private usuarioService: UsuarioService) {
        this.RetornarTodosUsuarios();
    }


    RetornarTodosUsuarios() {
        this.usuarios$ = this.usuarioService.RetornarTodos();
    }
}  

