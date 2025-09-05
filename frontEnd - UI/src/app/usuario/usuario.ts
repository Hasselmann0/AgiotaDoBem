import { Component, ViewChild, AfterViewInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatTableDataSource, MatTableModule } from '@angular/material/table';
import { MatPaginator, MatPaginatorModule } from '@angular/material/paginator';
import { MatSort, MatSortModule } from '@angular/material/sort';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { Observable } from 'rxjs';
import { takeUntilDestroyed } from '@angular/core/rxjs-interop';

import { UsuarioInterface } from '../intefaces/usuario.interface';
import { UsuarioService } from '../services/usuario.service';


@Component({
    selector: 'app-usuario',
    templateUrl: './usuario.html',
    styleUrl: './usuario.css',
    imports: [
        CommonModule,
        MatTableModule,
        MatPaginatorModule,
        MatSortModule,
        MatFormFieldModule,
        MatInputModule,
        MatButtonModule,
        MatIconModule,
    ],
})
export class Usuario implements AfterViewInit {

    dataSource = new MatTableDataSource<UsuarioInterface>([]);
    displayedColumns: string[] = ['id', 'nomeDoDevedor', 'nomeDoEstabelecimento', 'valorTotalDaCompra',
        'diaDaCompra', 'status'];

    @ViewChild(MatPaginator) paginator!: MatPaginator;
    @ViewChild(MatSort) sort!: MatSort;

    usuarios$ = new Observable<UsuarioInterface[]>();

    constructor(private usuarioService: UsuarioService) {
        this.RetornarTodosUsuarios();
    }


    RetornarTodosUsuarios() {
        this.usuarios$ = this.usuarioService.RetornarTodos();
        this.usuarios$.pipe(takeUntilDestroyed()).subscribe(users => {
            this.dataSource.data = users ?? [];
        })
    }
    
    ngAfterViewInit(): void {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
    } 
}  

