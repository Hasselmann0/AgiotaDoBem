import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { usuario } from '../intefaces/usuario.interface';

@Injectable({
    providedIn: 'root',
})
export class UsuarioService {

    private url = environment.api;

    constructor(private httpclient : HttpClient) {
    }

    RetornarTodos() {
        this.httpclient.get<usuario[]>(this.url + '/usuarios')
        
    }

}
