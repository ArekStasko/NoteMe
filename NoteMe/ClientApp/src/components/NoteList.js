import React, {Component} from 'react'


export class NoteList extends Component{
    
    constructor(props) {
        super(props);
        this.state = { 
            notes: [], 
            loading: true, 
            showAdd: false,
            title: "",
            description: "",
        }
    }
    
    componentDidMount() {
        this.GetNotesData();
    }
    
    Submit(e){
        e.preventDefault();
        this.setState({showAdd: !this.state.showAdd});
    }
    
    AddNote(e){
        e.preventDefault();
        
        const note = {
            Id: 1,
            Title: this.state.title,
            Description: this.state.description
        };
        
        fetch('notes/add', {
            method: 'POST',
            headers: {
                "Content-Type": "application/json",
            },
            body: JSON.stringify(note) 
        })
            .then(response => {
                console.log(response);
            })
            .catch(e => {
                console.log(e);
            })
    }
    
    DeleteNote(e, noteId){
        e.preventDefault();
        fetch('notes/delete', {
            method: 'DELETE',
                headers: {
                "Content-Type": "application/json",
            },
            body: JSON.stringify({Id: noteId})
        })
            .then(response => {
                console.log(response)
            })
            .catch(ex => {
                console.log(ex)
            })
    }
    
    render(){
        
        return this.state.loading ? (
            <div>
                <h1>Loading...</h1>
            </div>
        ): (
            <div>
                <h1>Notes :</h1>
                <button onClick={e => this.Submit(e)}>Add Note</button>
                {
                    this.state.showAdd ? (
                        <div>
                        <h3>Provide note info :</h3>
                            <form onSubmit={e => this.AddNote(e)} >
                                <div>
                                    <label>Title</label>
                                    <input type='text' onChange={e => this.setState({title: e.target.value})} value={this.state.title} />
                                </div>
                                <div>
                                    <label>Description</label>
                                    <input type='text' onChange={e => this.setState({description: e.target.value})} value={this.state.description} />
                                </div>
                                <button type="submit">Add</button>
                            </form>
                        </div>
                    ) : (
                        <>
                        </>
                    )
                }
                {
                    this.state.notes.map(note => (
                        <li key={note.id}>
                            <h3>{note.title}</h3>
                            <p>{note.description}</p>
                            <button>Update</button>
                            <button onClick={e => this.DeleteNote(e, note.id)}>Delete</button>
                        </li>
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
                console.log(data)
                this.setState({notes: data, loading: false})
            })
        console.log(this.state.notes)
    }
}

