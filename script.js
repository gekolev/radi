// Notes App with Local Storage

class NotesApp {
  constructor() {
    this.notes = this.loadNotes();
    this.initializeElements();
    this.addEventListeners();
    this.displayNotes();
  }

  initializeElements() {
    this.noteTitle = document.getElementById('noteTitle');
    this.noteContent = document.getElementById('noteContent');
    this.saveButton = document.getElementById('saveNote');
    this.clearButton = document.getElementById('clearNote');
    this.notesContainer = document.getElementById('notesContainer');
  }

  addEventListeners() {
    this.saveButton.addEventListener('click', () => this.saveNote());
    this.clearButton.addEventListener('click', () => this.clearForm());
    
    // Save note with Enter key (Ctrl+Enter for textarea)
    this.noteTitle.addEventListener('keypress', (e) => {
      if (e.key === 'Enter') {
        this.saveNote();
      }
    });
    
    this.noteContent.addEventListener('keypress', (e) => {
      if (e.key === 'Enter' && e.ctrlKey) {
        this.saveNote();
      }
    });
  }

  saveNote() {
    const title = this.noteTitle.value.trim();
    const content = this.noteContent.value.trim();

    if (!title && !content) {
      alert('Please enter a title or content for your note!');
      return;
    }

    const note = {
      id: Date.now(),
      title: title || 'Untitled Note',
      content: content,
      createdAt: new Date().toLocaleDateString('en-US', {
        year: 'numeric',
        month: 'short',
        day: 'numeric',
        hour: '2-digit',
        minute: '2-digit'
      })
    };

    this.notes.unshift(note); // Add to beginning of array
    this.saveNotes();
    this.displayNotes();
    this.clearForm();
    
    console.log('Note saved successfully!', note);
  }

  clearForm() {
    this.noteTitle.value = '';
    this.noteContent.value = '';
    this.noteTitle.focus();
  }

  deleteNote(id) {
    if (confirm('Are you sure you want to delete this note?')) {
      this.notes = this.notes.filter(note => note.id !== id);
      this.saveNotes();
      this.displayNotes();
      console.log('Note deleted successfully!');
    }
  }

  displayNotes() {
    if (this.notes.length === 0) {
      this.notesContainer.innerHTML = '<p class="no-notes">No notes yet. Create your first note above! ✨</p>';
      return;
    }

    this.notesContainer.innerHTML = this.notes.map(note => `
      <div class="note-card" data-id="${note.id}">
        <div class="note-header">
          <h3 class="note-title">${this.escapeHtml(note.title)}</h3>
          <button class="delete-btn" onclick="notesApp.deleteNote(${note.id})">🗑️</button>
        </div>
        <p class="note-content">${this.escapeHtml(note.content).replace(/\n/g, '<br>')}</p>
        <div class="note-date">${note.createdAt}</div>
      </div>
    `).join('');
  }

  escapeHtml(text) {
    const div = document.createElement('div');
    div.textContent = text;
    return div.innerHTML;
  }

  saveNotes() {
    try {
      localStorage.setItem('notesApp', JSON.stringify(this.notes));
    } catch (error) {
      console.error('Error saving notes to localStorage:', error);
      alert('Error saving notes. Your browser storage might be full.');
    }
  }

  loadNotes() {
    try {
      const saved = localStorage.getItem('notesApp');
      return saved ? JSON.parse(saved) : [];
    } catch (error) {
      console.error('Error loading notes from localStorage:', error);
      return [];
    }
  }
}

// Initialize the app when DOM is loaded
document.addEventListener('DOMContentLoaded', () => {
  window.notesApp = new NotesApp();
  console.log('Notes App loaded successfully!');
});

console.log("Script loaded successfully!");