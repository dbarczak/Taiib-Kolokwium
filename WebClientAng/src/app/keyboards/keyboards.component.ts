import { Component } from '@angular/core';
import { KeyboardResponse } from '../models/keyboardResponse.interface';
import { KeyboardService } from '../keyboard.service';
import { KeyboardRequest } from '../models/keyboardRequest.interface';

@Component({
  selector: 'app-keyboards',
  templateUrl: './keyboards.component.html',
  styleUrl: './keyboards.component.css',
})
export class KeyboardsComponent {
  public data: KeyboardResponse[] = [];
  public newKeyboard: KeyboardRequest = { model: '', rodzaj: 0 };
  public isFormVisible = false;
  public rodzaje = [
    { value: 0, label: 'Membranowa' },
    { value: 1, label: 'Nożycowa' },
    { value: 2, label: 'Mechaniczna' },
    { value: 3, label: 'Optyczna' },
    { value: 4, label: 'Hybrydowa' },
  ];

  constructor(private keyboardService: KeyboardService) {
    this.getData();
  }

  private getData(): void {
    this.keyboardService.get().subscribe({
      next: (res) => {
        this.data = res;
      },
      error: (err) => console.error(err),
      complete: () => console.log('complete'),
    });
  }

  public deleteKeyboard(id: number): void {
    this.keyboardService.delete(id).subscribe({
      next: () => {
        this.getData();
      },
      error: (err) => console.error(err),
      complete: () => console.log('complete'),
    });
  }

  public addKeyboard(): void {
    this.keyboardService.post(this.newKeyboard).subscribe({
      next: () => {
        this.newKeyboard = { model: '', rodzaj: 0 };
        this.isFormVisible = false;
        this.getData();
      },
      error: (err) => console.error(err),
      complete: () => console.log('complete'),
    });
  }

  public toggleForm(): void {
    this.isFormVisible = !this.isFormVisible;
  }
}
