import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Usuario } from "./usuario/usuario";
import { Header } from "./header/header";
import { Footer } from "./footer/footer";

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, Usuario, Header, Footer],
  templateUrl: './app.html',
  styleUrl: './app.scss',
})
export class App {
  protected readonly title = signal('AgiotaDoBem.UI');
}
