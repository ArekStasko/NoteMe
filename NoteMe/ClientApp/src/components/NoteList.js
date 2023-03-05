import React, {Component} from 'react'


export class NoteList extends Component{
    
    constructor(props) {
        super(props);
        this.state = { notes: [], loading: true }
    }
    
    componentDidMount() {
        this.GetNotesData();
    }
    
    render(){
        
        return this.state.loading ? (
            <div>
                <h1>Loading...</h1>
            </div>
        ): (
            <div>
                <h1>Notes :</h1>
                {
                    this.state.notes.map(note => (
                        <div>
                            <h3>{note.Title}</h3>
                            <p1>{note.Description}</p1>
                        </div>
                        ))
                }
            </div>
        )
        
    }

    async GetNotesData(){
        fetch('notes/getall')
            .then(result => {
                return result.json();
            })
            .then(data => {
                this.setState({notes: data, loading: false})
            })
    }
}

