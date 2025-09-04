import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Usuario } from "./usuario/usuario";

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, Usuario],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
  protected readonly title = signal('AgiotaDoBem.UI');
}
