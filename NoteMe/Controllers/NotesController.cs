﻿using Microsoft.AspNetCore.Mvc;
using NoteMe.Data.Models.Note;
using NoteMe.Processors.ProcessorsFactory;

namespace NoteMe.Controllers;

[ApiController]
[Route("[controller]")]
public class NotesController : ControllerBase
{
    private ILogger<NotesController> _logger;
    private IProcessorsFactory _processors;

    public NotesController(ILogger<NotesController> logger, IProcessorsFactory processors)
    {
        _processors = processors;
        _logger = logger;
    }

    [HttpGet]
    public List<Note> GetAll()
    {
        var processor = _processors.GetGetAllProcessorInstance();
        var notes = processor.Get();
        return notes;
    }

    [HttpGet]
    public Note Get(int Id)
    {
        var processor = _processors.GetGetSingleProcessorInstance();
        var note = processor.Get(Id);
        return note;
    }

    [HttpPost]
    public void Add(Note note)
    {
        var processor = _processors.GetAddProcessorInstance();
        processor.Add(note);
    }

    [HttpDelete]
    public void Delete(int Id)
    {
        var processor = _processors.GetDeleteProcessorInstance();
        processor.Delete(Id);
    }

    [HttpPut]
    public void Update(Note note)
    {
        var processor = _processors.GetUpdateProcessorInstance();
        processor.Update(note);
    }
}