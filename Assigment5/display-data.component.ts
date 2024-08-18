import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { DisplayDataService } from '../display-data.service';
import { DisplayDataClass } from '../display-data-class';

@Component({
  selector: 'app-display-data',
  standalone: true,
  imports: [FormsModule,CommonModule],
  templateUrl: './display-data.component.html',
  styleUrl: './display-data.component.css'
})
export class DisplayDataComponent {
  data: DisplayDataClass[] = [];
  selectedData: DisplayDataClass | null = null;
  selectedId: number = 0;

  constructor(private displayDataService: DisplayDataService) { }

  ngOnInit(): void {
    // Fetch all records on component load
    this.displayDataService.getInfo().subscribe((data: DisplayDataClass[]) => {
      this.data = data;
    });
  }

  onSelect(id: number): void {
    // Fetch and display data for the selected ID
    this.displayDataService.getDataById(id).subscribe((data: DisplayDataClass) => {
      this.selectedData = data;
    });
  }
}
