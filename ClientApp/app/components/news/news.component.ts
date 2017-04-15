import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';

@Component({
  selector: 'news',
  templateUrl: './news.component.html',
  styleUrls: ['./news.component.css']
})

export class NewsComponent implements OnInit {
  
  public NewsCasts: NewsCasts[];
  
  constructor(private http: Http) { 

}

ngOnInit () { 
       this.http.get('api/new/newscasts').subscribe(result => { 
        this.NewsCasts = result.json() as NewsCasts[];
  });
}

}

  interface NewsCasts {
    time: string;
    description: string; 
    views: number;
  }